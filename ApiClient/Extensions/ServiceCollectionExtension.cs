using ApiClient.Abstractions;
using ApiClient.HttpClients;
using Microsoft.Extensions.DependencyInjection;

namespace ApiClient.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddApiClient(this IServiceCollection services)
        {
            services.AddSingleton<IUserClient, UserClient>();
            services.AddSingleton<IGroupClient, GroupClient>();

            services.AddSingleton<IApiClient, MyApiClient>();
        }
    }
}
