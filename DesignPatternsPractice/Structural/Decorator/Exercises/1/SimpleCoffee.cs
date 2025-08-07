using DesignPatternsPractice.Structural.Decorator.Exercises._1.Interface;

public class SimpleCoffee : IBeverage
{
    public string GetDescription() => "Simple Coffee";
    public decimal GetCost() => 5.0m;
}
