using Microsoft.Extensions.DependencyInjection;
using Models;

namespace Example.BuilderPattern.DependencyResolver
{
    public static class ServiceCollectionExtension
    {
        public static void AddBuilders(this IServiceCollection services)
        {
            services.AddTransient<IBuilder<Order>, OrderBuilder>();
            services.AddTransient<IBuilder<Burger>, BurgerBuilder>();
        }
    }
}
