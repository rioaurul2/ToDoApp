using DesignPatternsPractice.Creational.Factory.Exercitii._3.Interface;

namespace DesignPatternsPractice.Creational.Factory.Exercitii._3;

public class PayPal : IPayment
{
    public void Pay()
    {
        Console.WriteLine("Payment was done with PayPal");
    }
}
