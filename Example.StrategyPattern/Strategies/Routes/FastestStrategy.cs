using Example.StrategyPattern.Models;
using System;

namespace Example.StrategyPattern.Strategies.Routes
{
    public class FastestStrategy : IRouteStrategy
    {
        public string Name => "Fastest";

        public Route GetRoute()
        {
            return new Route
            {
                Path = "a1->a2->b3",
                Duration = DateTime.UtcNow.AddHours(1) - DateTime.UtcNow
            };
        }
    }
}
