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
using Xunit;

namespace Application.IntegrationTests
{
    public class Testing : IAsyncLifetime

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

        EnsureDatabase();

        _checkpoint = new Checkpoint
        {
            DbAdapter = DbAdapter.Postgres,
            TablesToIgnore = new[] { "__EFMigrationsHistory" }
        };
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

    }


    public static async Task<TEntity> FindAsync<TEntity>(params object[] keyValues)
        where TEntity : class
    {
        using var scope = _scopeFactory.CreateScope();

        var context = scope.ServiceProvider.GetService<DataContext>();

        return await context.FindAsync<TEntity>(keyValues);
    }

    public static async Task AddAsync<TEntity>(TEntity entity)
        where TEntity : class
    {
        using var scope = _scopeFactory.CreateScope();

        var context = scope.ServiceProvider.GetService<DataContext>();

        context.Add(entity);

        await context.SaveChangesAsync();
    }

    public static async Task<int> CountAsync<TEntity>() where TEntity : class
    {
        using var scope = _scopeFactory.CreateScope();

        var context = scope.ServiceProvider.GetService<DataContext>();

        return await context.Set<TEntity>().CountAsync();
    }

    public async Task InitializeAsync()
    {
        using (var conn = new NpgsqlConnection(_configuration.GetConnectionString("PostgreSQL")))
        {
            await conn.OpenAsync();

            await _checkpoint.Reset(conn);
        }

        //auth
        //_currentUserId = null;
    }

    public Task DisposeAsync()
    {
        return Task.CompletedTask;
    }
    }
}