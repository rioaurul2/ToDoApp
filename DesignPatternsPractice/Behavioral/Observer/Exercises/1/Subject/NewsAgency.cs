public class NewsAgency : ISubjectEx1
{
    private List<IObserverEx1> _observers = new();

    public void Attach(IObserverEx1 observer)
    {
        _observers.Add(observer);
    }

    public void Detach(IObserverEx1 observer)
    {
        _observers.Remove(observer);
    }

    public void Notify(string news)
    {
        foreach (var observer in _observers)
        {
            observer.Update(news);
        }
    }

    // Metodă pentru a publica o știre
    public void PublishNews(string news)
    {
        Console.WriteLine($"[NewsAgency] Breaking News: {news}");
        Notify(news);
    }
}
