using DesignPatternsPractice.Structural.Decorator.Exercises._1.Interface;

public class ChocolateDecorator : BeverageDecorator
{
    public ChocolateDecorator(IBeverage beverage) : base(beverage) { }

    public override string GetDescription() => _beverage.GetDescription() + ", Chocolate";

    public override decimal GetCost() => _beverage.GetCost() + 3.0m;
}