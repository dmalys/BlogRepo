using ApplicationLayer.Services.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace ApplicationLayer
{
    public static class DependancyInjection
    {
        public static IServiceCollection AddApplicationModules(this IServiceCollection services)
        {
            services.AddScoped<IAuthenticationService, AuthenticationService>();

            return services;
        }
    }
}