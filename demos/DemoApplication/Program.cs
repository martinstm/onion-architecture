using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Example.BuilderPattern.DependencyResolver;
using Example.CommandPattern.DependencyResolver;
using Example.Infrastructure.DependencyResolver;
using Example.StrategyPattern.DependencyResolver;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DemoApplication
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
                    services.AddCommands();
                    services.AddBuilders();
                    services.AddStrategies();
                    services.AddHostedService<Worker>();
                });
    }
}
