using Application;
using Application.Core;
using MediatR;
using MicroElements.Swashbuckle.FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Persistence;

namespace API.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {

            services.AddDbContext<DataContext>(options =>
                options.UseNpgsql(config.GetConnectionString("PostgreSQL")));
            services.AddDatabaseDeveloperPageExceptionFilter();

            //set up CORS with named policy and middleware (https://docs.microsoft.com/en-us/aspnet/core/security/cors?view=aspnetcore-5.0)
            services.AddCors(options =>
            {
                options.AddPolicy(name: Startup.ClientOrigin,
                    builder =>
                    {
                        builder
                            .AllowAnyOrigin()
                            .AllowAnyMethod()
                            .AllowAnyHeader();
                    });
            });

            services.AddSwaggerGen(c => { c.SwaggerDoc("v1", new OpenApiInfo { Title = "API", Version = "v1" }); });
            services.AddFluentValidationRulesToSwagger();

            services.AddMediatR(typeof(MediatREntrypoint).Assembly);
            services.AddAutoMapper(typeof(MappingProfiles).Assembly);

            return services;
        }
    }
}