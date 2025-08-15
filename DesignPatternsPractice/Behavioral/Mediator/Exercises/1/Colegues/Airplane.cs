public class Airplane
{
    private readonly IAirTrafficControl _atc;
    public string FlightCode { get; }

    public Airplane(string code, IAirTrafficControl atc)
    {
        FlightCode = code;
        _atc = atc;
    }

    public void RequestLanding()
    {
        _atc.RequestToLand(FlightCode);
    }
}
