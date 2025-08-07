using DesignPatternsPractice.Structural.Decorator.Exercises._1.Interface;

public abstract class BeverageDecorator : IBeverage
{
    protected IBeverage _beverage;

    protected BeverageDecorator(IBeverage beverage)
    {
        _beverage = beverage;
    }

    public abstract string GetDescription();
    public abstract decimal GetCost();
}
