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

        public static async Task<string> RunAsDefaultUserAsync()
        {
            return await RunAsUserAsync("test@test.com", "Pa$$w0rd", false, false);
        }

        public static async Task<string> RunAsClientUserAsync()
        {
            return await RunAsUserAsync("test@test.com", "Pa$$w0rd", true, false);
        }

        public static async Task<string> RunAsVendorUserAsync()
        {
            return await RunAsUserAsync("test@test.com", "Pa$$w0rd", false, true);
        }


        //roles handling deleted
        public static async Task<string> RunAsUserAsync(string userName, string password, bool isClient,
            bool isVendor)
        {
            using var scope = _scopeFactory.CreateScope();

            var userManager = scope.ServiceProvider.GetService<UserManager<Account>>();
            var context = scope.ServiceProvider.GetService<DataContext>();

            var user = new Account { UserName = userName, Email = userName };

            var result = await userManager.CreateAsync(user, password);

            if (isClient)
            {
                var client = ClientFaker.CreateWithAccount(1, new List<Account>() { user }).Generate();
                await context.Clients.AddAsync(client);
            }

            if (isVendor)
            {
                var vendor = VendorFaker.CreateWithAccount(1, new List<Account>() { user }).Generate();
                await context.Vendors.AddAsync(vendor);
            }

            await context.SaveChangesAsync();

            //var errors = string.Join(Environment.NewLine, result.ToApplicationResult().Errors);
            if (!result.Succeeded) throw new Exception($"Unable to create {userName}.{Environment.NewLine}");
            _currentUserId = user.Id;

            return _currentUserId;
        }
    }
}