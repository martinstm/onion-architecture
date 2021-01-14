using Example.Core.DomainServices.Repositories;
using Example.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Example.Infrastructure.DependencyResolver
{
    public static class ServiceCollectionExtension
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IGroupRepository, GroupRepository>();
        }
    }
}
