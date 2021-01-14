using Example.StrategyPattern.Services;
using Example.StrategyPattern.Services.Abstractions;
using Example.StrategyPattern.Strategies.Routes;
using Microsoft.Extensions.DependencyInjection;

namespace Example.StrategyPattern.DependencyResolver
{
    public static class ServiceCollectionExtension
    {
        public static void AddStrategies(this IServiceCollection services)
        {
            services.AddScoped<IRouteStrategy, FastestStrategy>();
            services.AddScoped<IRouteStrategy, BeautifulStrategy>();
            services.AddScoped<IRouteStrategy, EconomicStrategy>();

            services.AddTransient<IRouteService, RouteService>();
        }
    }
}
