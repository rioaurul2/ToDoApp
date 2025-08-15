public class AirTrafficControl : IAirTrafficControl
{
    private bool _runwayFree = true;
    private string _runwayName;

    public void RegisterRunway(string name)
    {
        _runwayName = name;
        Console.WriteLine($"Runway '{name}' registered.");
    }

    public bool RequestToLand(string flightCode)
    {
        if (_runwayFree)
        {
            Console.WriteLine($"Flight {flightCode} cleared to land on {_runwayName}.");
            _runwayFree = false;
            return true;
        }
        else
        {
            Console.WriteLine($"Flight {flightCode} HOLD, runway busy.");
            return false;
        }
    }

    // Simulăm eliberarea pistei
    public void RunwayClear()
    {
        Console.WriteLine($"Runway {_runwayName} is now clear.");
        _runwayFree = true;
    }
}
