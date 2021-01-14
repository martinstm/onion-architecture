using Example.Core.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Example.Core.Application.DependencyResolver
{
    public static class ServiceCollectionExtension
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddTransient<IGroupService, GroupService>();
            services.AddTransient<IUserService, UserService>();
        }
    }
}
