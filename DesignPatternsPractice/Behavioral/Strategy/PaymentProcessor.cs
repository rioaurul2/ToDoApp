using DesignPatternsPractice.Behavioral.Strategy.Interfaces;

namespace DesignPatternsPractice.Behavioral.Strategy;

public class PaymentProcessor
{
    private IPaymentStrategy _strategy;

    public PaymentProcessor(IPaymentStrategy strategy)
    {
        _strategy = strategy;
    }

    public void ChangeStrategy(IPaymentStrategy strategy)
    {
        _strategy = strategy;
    }

    public void ExecutePayment(decimal amount)
    {
        _strategy.Pay(amount);
    }
}
/*
    IPaymentStrategy definește comportamentul comun.

    Fiecare clasă concretă implementează o variantă de algoritm.

    PaymentProcessor e complet decupat de la logica fiecărei metode — doar folosește strategia.
 */