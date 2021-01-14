using System;
using System.Collections.Generic;
using System.Linq;
using ApiClient.Extensions;
using Example.BuilderPattern.DependencyResolver;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MicroserviceApp
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
                    services.AddApiClient();
                    services.AddBuilders();
                    services.AddHostedService<Worker>();
                });
    }
}
