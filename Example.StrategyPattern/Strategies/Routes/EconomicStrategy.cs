using Example.StrategyPattern.Models;
using System;

namespace Example.StrategyPattern.Strategies.Routes
{
    public class EconomicStrategy : IRouteStrategy
    {
        public string Name => "Economic";

        public Route GetRoute()
        {
            return new Route
            {
                Path = "a1->a2->b1->b3",
                Duration = DateTime.UtcNow.AddHours(2) - DateTime.UtcNow
            };
        }
    }
}
