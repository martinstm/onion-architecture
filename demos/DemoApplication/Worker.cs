using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Example.BuilderPattern;
using Example.Core.DomainServices.Repositories;
using Example.StrategyPattern;
using Example.StrategyPattern.Models;
using Example.StrategyPattern.Services.Abstractions;
using Example.StrategyPattern.Strategies.Routes;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Models;

namespace DemoApplication
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IBuyerRepository _buyerRepository;
        private readonly ISellerRepository _sellerRepository;
        private readonly IRouteService _routeService;

        public Worker(ILogger<Worker> logger, 
                      IBuyerRepository buyerRepository, 
                      ISellerRepository sellerRepository,
                      IRouteService routeService)
        {
            _logger = logger;
            _buyerRepository = buyerRepository;
            _sellerRepository = sellerRepository;
            _routeService = routeService;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            // BUILDERS
            BurgerBuilder burgerBuilder = new BurgerBuilder();
            Burger burger = burgerBuilder.WithCheese().WithBacon().Build();

            Order order = OrderBuilder.Init(_buyerRepository, _sellerRepository)
                                      .SetBuyer(1)
                                      .SetSeller(2)
                                      .Build();

            var a = new Burger(true, true, false, false, false);


            // STRATEGIES
            Route routeResult = _routeService.GetRoute("Fastest");


            Context context = new Context(new FastestStrategy());
            Route fastestRoute = context.ExecuteStrategy();

            context.SetStrategy(new BeautifulStrategy());
            Route beautifulRoute = context.ExecuteStrategy();

            context.SetStrategy(new EconomicStrategy());
            Route economicRoute = context.ExecuteStrategy();

            _logger.LogInformation("----- STRATEGIES ROUTES -----");
            _logger.LogInformation($"Fastest -> Time: {fastestRoute.Duration} - Path: {fastestRoute.Path}");
            _logger.LogInformation($"Beautiful -> Time: {beautifulRoute.Duration} - Path: {beautifulRoute.Path}");
            _logger.LogInformation($"Economic -> Time: {economicRoute.Duration} - Path: {economicRoute.Path}");
        }
    }
}
