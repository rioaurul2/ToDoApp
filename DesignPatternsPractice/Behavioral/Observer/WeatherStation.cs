public class WeatherStation : ISubject
{
    private readonly List<IObserver> _observers = new();
    private float _temperature;

    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void SetTemperature(float temperature)
    {
        Console.WriteLine($"WeatherStation: New temperature is {temperature}°C");
        _temperature = temperature;
        Notify();
    }

    public void Notify()
    {
        foreach (var observer in _observers)
        {
            observer.Update(_temperature);
        }
    }
}
