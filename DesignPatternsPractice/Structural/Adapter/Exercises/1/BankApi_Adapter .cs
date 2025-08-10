using DesignPatternsPractice.Structural.Adapter.Exercises._1.Interfaces;

public class BankApi_Adapter : IPaymentProcessor_Adapter
{
    private readonly LegacyBankApi_Adapter _legacyApi;

    public BankApi_Adapter(LegacyBankApi_Adapter legacyApi)
    {
        _legacyApi = legacyApi;
    }

    public void Pay(string account, decimal amount)
    {
        // Transformăm parametrii sau apelurile dacă e nevoie
        _legacyApi.MakePayment(account, amount);
    }
}
