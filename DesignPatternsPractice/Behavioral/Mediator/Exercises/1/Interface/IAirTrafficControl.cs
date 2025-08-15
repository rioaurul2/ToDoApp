public interface IAirTrafficControl
{
    void RegisterRunway(string name);
    bool RequestToLand(string flightCode);
}
