namespace DesignPatternsPractice.Behavioral.Strategy.Exercises._1.Interfaces;

public interface ITransportStrategy
{
    decimal CalculateCost(decimal distanceKm, decimal weightKg);
}