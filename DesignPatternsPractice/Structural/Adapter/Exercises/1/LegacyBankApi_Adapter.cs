public class LegacyBankApi_Adapter
{
    public void MakePayment(string iban, decimal value)
    {
        Console.WriteLine($"Payment of {value} made to {iban} via Legacy Bank API");
    }
}
