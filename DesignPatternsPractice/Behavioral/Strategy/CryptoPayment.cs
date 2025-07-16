using DesignPatternsPractice.Behavioral.Strategy.Interfaces;

public class CryptoPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paid {amount} RON using Crypto.");
    }
}
