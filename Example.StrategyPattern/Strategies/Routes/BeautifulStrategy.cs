using Example.StrategyPattern.Models;
using System;

namespace Example.StrategyPattern.Strategies.Routes
{
    public class BeautifulStrategy : IRouteStrategy
    {
        public string Name => "Beautiful";

        public Route GetRoute()
        {
            return new Route
            {
                Path = "a1->a2->b1->b2->b3",
                Duration = DateTime.UtcNow.AddHours(3) - DateTime.UtcNow
            };
        }
    }
}
