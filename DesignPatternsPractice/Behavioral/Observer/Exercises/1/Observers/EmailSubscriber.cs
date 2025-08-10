namespace DesignPatternsPractice.Behavioral.Observer.Exercises._1.Observers;

public class EmailSubscriber : IObserverEx1
{
    private string _email;

    public EmailSubscriber(string email)
    {
        _email = email;
    }

    public void Update(string news)
    {
        Console.WriteLine($"Email to {_email}: {news}");
    }
}
