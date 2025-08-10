namespace DesignPatternsPractice.Behavioral.Observer.Exercises._1.Observers;

public class SmsSubscriber : IObserverEx1
{
    private string _phone;

    public SmsSubscriber(string phone)
    {
        _phone = phone;
    }

    public void Update(string news)
    {
        Console.WriteLine($"SMS to {_phone}: {news}");
    }
}
