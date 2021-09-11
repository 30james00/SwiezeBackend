using System.IO;
using System.Threading.Tasks;
using API;
using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using Npgsql;
using Persistence;
using Respawn;

namespace Application.IntegrationTests
{
    public class Testing
    {
        private static IConfigurationRoot _configuration;
        private static IServiceScopeFactory _scopeFactory;
        private static Checkpoint _checkpoint;

        
        public Testing()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
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
        
        public static async Task<TResponse> SendAsync<TResponse>(IRequest<TResponse> request)
        {
            using var scope = _scopeFactory.CreateScope();

            var mediator = scope.ServiceProvider.GetService<ISender>();

            return await mediator.Send(request);
        }

        public static async Task ResetState()
        {
            using (var conn = new NpgsqlConnection(_configuration.GetConnectionString("PostgreSQL")))
            {
                await conn.OpenAsync();

                await _checkpoint.Reset(conn);
            }
            
            //auth
            //_currentUserId = null;
        }
    }
}