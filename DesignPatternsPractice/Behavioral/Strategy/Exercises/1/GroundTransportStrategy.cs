using DesignPatternsPractice.Behavioral.Strategy.Exercises._1.Interfaces;

namespace DesignPatternsPractice.Behavioral.Strategy.Exercises._1;

public class GroundTransportStrategy : ITransportStrategy
{
    public decimal CalculateCost(decimal distanceKm, decimal weightKg)
    {
        return 0.5m * distanceKm + 0.2m * weightKg;
    }
}
