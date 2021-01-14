using Example.Core.Application.DependencyResolver;
using Example.Infrastructure.DependencyResolver;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace OnionApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddRepositories();
                    services.AddServices();
                    services.AddHostedService<Worker>();
                });
    }
}
