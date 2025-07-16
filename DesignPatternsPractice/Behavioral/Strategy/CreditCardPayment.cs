using DesignPatternsPractice.Behavioral.Strategy.Interfaces;

namespace DesignPatternsPractice.Behavioral.Strategy;

public class CreditCardPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paid {amount} RON using Credit Card.");
    }
}
