using Application;
using Application.Core;
using Application.Interfaces;
using Application.Services;
using Infrastructure.Payments;
using Infrastructure.Photos;
using Infrastructure.Security;
using MediatR;
using MicroElements.Swashbuckle.FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Persistence;
using Stripe;
using AccountService = Application.Services.AccountService;
using CouponService = Application.Services.CouponService;

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

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Greengrocers",
                    Version = "v1"
                });

                // add JWT Authentication
                var securityScheme = new OpenApiSecurityScheme
                {
                    Name = "JWT Authentication",
                    Description = "Enter JWT Bearer token **_only_**",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.Http,
                    Scheme = "bearer", // must be lower case
                    BearerFormat = "JWT",
                    Reference = new OpenApiReference
                    {
                        Id = JwtBearerDefaults.AuthenticationScheme,
                        Type = ReferenceType.SecurityScheme
                    }
                };
                c.AddSecurityDefinition(securityScheme.Reference.Id, securityScheme);
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    { securityScheme, System.Array.Empty<string>() }
                });
            });
            services.AddFluentValidationRulesToSwagger();

            //Configure Stripe
            StripeConfiguration.ApiKey = config["Stripe"];

            services.AddMediatR(typeof(MediatREntrypoint).Assembly);
            services.AddAutoMapper(typeof(MappingProfiles).Assembly);
            services.AddScoped<IUserAccessor, UserAccessor>();
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<ICouponService, CouponService>();

            services.AddScoped<IPaymentsAccessor, PaymentsAccessor>();
            services.AddScoped<IPhotoAccessor, PhotoAccessor>();
            services.Configure<CloudinarySettings>(config.GetSection("Cloudinary"));

            return services;
        }
    }
}