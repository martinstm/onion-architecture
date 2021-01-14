using Example.StrategyPattern.Models;
using Example.StrategyPattern.Services.Abstractions;
using Example.StrategyPattern.Strategies.Routes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Example.StrategyPattern.Services
{
    public class RouteService : IRouteService
    {
        //public Route GetRoute(string strategyType)
        //{
        //    IRouteStrategy routeStrategy = _strategies[strategyType];
        //    return routeStrategy.GetRoute();
        //}

        public Route GetRoute(string strategyType)
        {
            return RouteStrategyFactory.GetStrategy(strategyType).GetRoute();
        }
    }
}
