using Example.StrategyPattern.Models;
using Example.StrategyPattern.Strategies.Routes;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Example.StrategyPattern
{
    public class Context
    {
        // Each key now returns a function that will instantiate an object when executed.
        private IDictionary<string, Func<IRouteStrategy>> strategies = new Dictionary<string, Func<IRouteStrategy>>() {
            { "Fastest", () => new FastestStrategy() },
            { "Economic", () => new EconomicStrategy() },
            { "Beautiful", () => new BeautifulStrategy() }
        };

        private IRouteStrategy _strategy;

        public Context(IRouteStrategy strategy) 
        {
            SetStrategy(strategy);
        }

        public void SetStrategy(IRouteStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(string strategy)
        {
            _strategy = strategies[strategy]();
        }

        public Route ExecuteStrategy()
        {
            return _strategy.GetRoute();
        }
    }
}
