namespace DesignPatternsPractice.Structural.Facade;

public class PaymentService
{
    public void ProcessPayment(string user)
    {
        Console.WriteLine($"[Payment] Procesare plată pentru {user}");
    }
}
