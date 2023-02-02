using DinnerApp.Application.Common.Interfaces.Authentication;
using DinnerApp.Application.Common.Interfaces.Services;
using DinnerApp.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DinnerApp.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
            services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
            return services;
        }
    }
}