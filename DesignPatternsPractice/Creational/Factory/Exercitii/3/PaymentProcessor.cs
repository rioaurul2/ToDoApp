using DesignPatternsPractice.Creational.Factory.Exercitii._3.Interface;

namespace DesignPatternsPractice.Creational.Factory.Exercitii._3;

public class PaymentProcessor : IPaymentProcessor
{
    public IPayment PayMethod(PaymentType paymentType)
    {
        return paymentType switch
        {
            PaymentType.Card => new Card(),
            PaymentType.Paypal => new PayPal(),
            _ => throw new NotSupportedException($"The providet type {paymentType} is not supported"),
        };
    }
}
