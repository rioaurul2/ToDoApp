using DesignPatternsPractice.Behavioral.Strategy.Exercises._1.Interfaces;

namespace DesignPatternsPractice.Behavioral.Strategy.Exercises._1.StrategyOrchestrator;

public class ShippingCostCalculator
{
    private ITransportStrategy _transportStrategy;

    public ShippingCostCalculator(ITransportStrategy transportStrategy)
    {
        _transportStrategy = transportStrategy;
    }

    public void SetStrategy(ITransportStrategy newTransportStrategy)
    {
        _transportStrategy = newTransportStrategy;
    }

    public decimal Calculate(decimal distanceKm, decimal weightKg)
    {
        return _transportStrategy.CalculateCost(distanceKm, weightKg);
    }
}
