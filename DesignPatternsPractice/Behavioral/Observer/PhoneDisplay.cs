public class PhoneDisplay : IObserver
{
    private readonly string _name;

    public PhoneDisplay(string name)
    {
        _name = name;
    }

    public void Update(float temperature)
    {
        Console.WriteLine($"{_name} Display: Temperature updated to {temperature}°C");
    }
}
