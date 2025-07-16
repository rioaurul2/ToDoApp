using DesignPatternsPractice.Behavioral.Strategy.Interfaces;

public class PayPalPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paid {amount} RON using PayPal.");
    }
}
