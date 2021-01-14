using Example.StrategyPattern.Models;
using System;

namespace Example.StrategyPattern.Strategies.Routes
{
    public interface IRouteStrategy
    {
        string Name { get; }
        Route GetRoute();
    }
}
