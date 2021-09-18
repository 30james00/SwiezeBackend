using Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence;

namespace API.Extensions
{
    public static class IdentityServiceExtensions
    {
        public static IServiceCollection AddIdentityServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddIdentityCore<Account>(options => { })
                .AddEntityFrameworkStores<DataContext>()
                .AddSignInManager<SignInManager<Account>>();

            services.AddAuthentication();

            return services;
        }
    }
}