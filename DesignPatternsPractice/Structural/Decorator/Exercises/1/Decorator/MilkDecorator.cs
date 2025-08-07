using DesignPatternsPractice.Structural.Decorator.Exercises._1.Interface;

public class MilkDecorator : BeverageDecorator
{
    public MilkDecorator(IBeverage beverage) : base(beverage) { }

    public override string GetDescription() => _beverage.GetDescription() + ", Milk";

    public override decimal GetCost() => _beverage.GetCost() + 1.5m;
}