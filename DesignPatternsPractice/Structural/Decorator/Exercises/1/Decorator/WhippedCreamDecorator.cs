using DesignPatternsPractice.Structural.Decorator.Exercises._1.Interface;

public class WhippedCreamDecorator : BeverageDecorator
{
    public WhippedCreamDecorator(IBeverage beverage) : base(beverage) { }

    public override string GetDescription() => _beverage.GetDescription() + ", Whipped Cream";

    public override decimal GetCost() => _beverage.GetCost() + 2.0m;
}