using DesignPatternsPractice.Structural.Adapter;

public class WeatherAdapter : IOldWeatherProvider
{
    private readonly NewWeatherService _newService;

    public WeatherAdapter(NewWeatherService newService)
    {
        _newService = newService;
    }

    public string GetWeather()
    {
        return _newService.GetCurrentTemperature();
    }
}
