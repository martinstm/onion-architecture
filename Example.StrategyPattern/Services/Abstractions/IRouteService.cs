using Example.StrategyPattern.Models;

namespace Example.StrategyPattern.Services.Abstractions
{
    public interface IRouteService
    {
        Route GetRoute(string strategyType);
    }
}