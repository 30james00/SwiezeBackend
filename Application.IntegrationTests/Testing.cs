using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using API;
using Application.Interfaces;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using Npgsql;
using NUnit.Framework;
using Persistence;
using Persistence.Faker;
using Respawn;

namespace Application.IntegrationTests
{
    [SetUpFixture]
    public class Testing
    {
        private static IConfigurationRoot _configuration;
        private static IServiceScopeFactory _scopeFactory;
        private static Checkpoint _checkpoint;
        private static string _currentUserId;

        [OneTimeSetUp]
        public void RunBeforeAnyTest()
        {
            var builder = new ConfigurationBuilder()
                .AddUserSecrets<Testing>()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.Development.json", true, true)
                .AddEnvironmentVariables();

            _configuration = builder.Build();

            var startup = new Startup(_configuration);

            var services = new ServiceCollection();

            services.AddSingleton(Mock.Of<IWebHostEnvironment>(w =>
                w.EnvironmentName == "Development" &&
                w.ApplicationName == "API"
            ));

            services.AddLogging();

            startup.ConfigureServices(services);

            //auth config here
            var currentUserServiceDescriptor = services.FirstOrDefault(d =>
                d.ServiceType == typeof(IUserAccessor));

            services.Remove(currentUserServiceDescriptor);

            // Register testing version
            services.AddScoped(provider =>
                Mock.Of<IUserAccessor>(s => s.GetUserId() == _currentUserId));

            _scopeFactory = services.BuildServiceProvider().GetService<IServiceScopeFactory>();

            _checkpoint = new Checkpoint
            {
                DbAdapter = DbAdapter.Postgres,
                TablesToIgnore = new[] { "__EFMigrationsHistory" }
            };

            EnsureDatabase();
        }

        private static void EnsureDatabase()
        {
            using var scope = _scopeFactory.CreateScope();

            var context = scope.ServiceProvider.GetService<DataContext>();

            context.Database.Migrate();
        }

        public static async Task ResetState()
        {
            using (var conn = new NpgsqlConnection(_configuration.GetConnectionString("PostgreSQL")))
            {
                await conn.OpenAsync();

                await _checkpoint.Reset(conn);
            }

            //auth
            _currentUserId = null;
        }

        public static async Task<TResponse> SendAsync<TResponse>(IRequest<TResponse> request)
        {
            using var scope = _scopeFactory.CreateScope();

            var mediator = scope.ServiceProvider.GetService<ISender>();

            return await mediator.Send(request);
        }

        public static async Task<TEntity> FindAsync<TEntity>(params object[] keyValues)
            where TEntity : class
        {
            using var scope = _scopeFactory.CreateScope();

            var context = scope.ServiceProvider.GetService<DataContext>();

            return await context.FindAsync<TEntity>(keyValues);
        }

        public static async Task<TEntity> AddAsync<TEntity>(TEntity entity)
            where TEntity : class
        {
            using var scope = _scopeFactory.CreateScope();

            var context = scope.ServiceProvider.GetService<DataContext>();

            var result = context.Add(entity);

            await context.SaveChangesAsync();

            return result.Entity;
        }

        public static async Task<int> CountAsync<TEntity>() where TEntity : class
        {
            using var scope = _scopeFactory.CreateScope();

            var context = scope.ServiceProvider.GetService<DataContext>();

            return await context.Set<TEntity>().CountAsync();
        }

        public static async Task SeedAsync()
        {
            using var scope = _scopeFactory.CreateScope();

            var context = scope.ServiceProvider.GetService<DataContext>();
            var userManager = scope.ServiceProvider.GetService<UserManager<Account>>();

            await Seed.SeedData(context, userManager, true);
        }

        public static async Task<(string, Guid)> RunAsDefaultUserAsync()
        {
            return await RunAsUserAsync("test", "Pa$$w0rd", false, false);
        }

        public static async Task<(string, Guid)> RunAsClientUserAsync()
        {
            return await RunAsUserAsync("test1", "Pa$$w0rd", true, false);
        }

        public static async Task<(string, Guid)> RunAsClient2UserAsync()
        {
            return await RunAsUserAsync("test2", "Pa$$w0rd", true, false);
        }

        public static async Task<(string, Guid)> RunAsVendorUserAsync()
        {
            return await RunAsUserAsync("test3", "Pa$$w0rd", false, true);
        }

        public static async Task<(string, Guid)> RunAsVendor2UserAsync()
        {
            return await RunAsUserAsync("test4", "Pa$$w0rd", false, true);
        }

        //roles handling deleted
        /// <summary>
        /// Create and login new user
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <param name="isClient"></param>
        /// <param name="isVendor"></param>
        /// <returns>Tuple containing accountId and id of Client or Vendor</returns>
        /// <exception cref="Exception"></exception>
        public static async Task<(string, Guid)> RunAsUserAsync(string userName, string password, bool isClient,
            bool isVendor)
        {
            using var scope = _scopeFactory.CreateScope();

            var userManager = scope.ServiceProvider.GetService<UserManager<Account>>();
            var context = scope.ServiceProvider.GetService<DataContext>();

            var user = new Account { UserName = userName, Email = userName + "@test.com" };

            var result = await userManager.CreateAsync(user, password);

            var id = Guid.Empty;

            if (isClient)
            {
                var client = new Client
                {
                    AccountId = user.Id,
                    FirstName = "Test",
                    LastName = "Test",
                };
                await context.Clients.AddAsync(client);
                id = client.Id;
            }

            if (isVendor)
            {
                var vendor = new Domain.Vendor
                {
                    AccountId = user.Id,
                    Name = "Test",
                };
                await context.Vendors.AddAsync(vendor);
                id = vendor.Id;
            }

            await context.SaveChangesAsync();

            //var errors = string.Join(Environment.NewLine, result.ToApplicationResult().Errors);
            if (!result.Succeeded) throw new Exception($"Unable to create {userName}.{Environment.NewLine}");
            _currentUserId = user.Id;

            return (_currentUserId, id);
        }

        /// <summary>
        /// Log in as user with his Account Email
        /// </summary>
        /// <param name="id">Known email of existing Account</param>
        public static async Task LogInAsUserAsync(string email)
        {
            using var scope = _scopeFactory.CreateScope();

            var userManager = scope.ServiceProvider.GetService<UserManager<Account>>();

            var account = await userManager.FindByEmailAsync(email);

            _currentUserId = account.Id;
        }
    }
}