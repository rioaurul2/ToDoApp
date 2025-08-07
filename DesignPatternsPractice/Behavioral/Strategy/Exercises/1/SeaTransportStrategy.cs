using DesignPatternsPractice.Behavioral.Strategy.Exercises._1.Interfaces;

namespace DesignPatternsPractice.Behavioral.Strategy.Exercises._1;

public class SeaTransportStrategy : ITransportStrategy
{
    public decimal CalculateCost(decimal distanceKm, decimal weightKg)
    {
        return 0.3m * distanceKm + 0.1m * weightKg;
    }
}
