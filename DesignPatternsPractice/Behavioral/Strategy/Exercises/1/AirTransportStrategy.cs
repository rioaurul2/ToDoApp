using DesignPatternsPractice.Behavioral.Strategy.Exercises._1.Interfaces;

namespace DesignPatternsPractice.Behavioral.Strategy.Exercises._1;

public class AirTransportStrategy : ITransportStrategy
{
    public decimal CalculateCost(decimal distanceKm, decimal weightKg)
    {
        return 1.0m * distanceKm + 0.5m * weightKg;
    }
}