using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example.StrategyPattern.Strategies.Routes
{
    public class RouteStrategyFactory
    {
        private static IDictionary<string, Func<IRouteStrategy>> _strategies = new Dictionary<string, Func<IRouteStrategy>>() {
            { "Fastest", () => new FastestStrategy() },
            { "Economic", () => new EconomicStrategy() },
            { "Beautiful", () => new BeautifulStrategy() }
        };

        private static List<IRouteStrategy> routeStrategies = new List<IRouteStrategy>()
        {
            new FastestStrategy(),
            new EconomicStrategy(),
            new BeautifulStrategy()
        };

        public static IRouteStrategy GetStrategy(string name)
        {
            return _strategies[name]();
            return routeStrategies.SingleOrDefault(r => r.Name == name);
        }
    }
}
