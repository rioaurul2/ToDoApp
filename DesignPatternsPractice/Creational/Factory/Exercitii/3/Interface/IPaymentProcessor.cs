namespace DesignPatternsPractice.Creational.Factory.Exercitii._3.Interface;

public interface IPaymentProcessor
{
    IPayment PayMethod(PaymentType paymentType);
}
