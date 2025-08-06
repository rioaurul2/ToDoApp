using DesignPatternsPractice.Creational.Abstract_Factory.Exercitii._1.Interfaces;

public class VehicleClient
{
    private readonly ICar _car;
    private readonly IScooter _scooter;

    public VehicleClient(IVehicleFactory factory)
    {
        _car = factory.CreateCar();
        _scooter = factory.CreateScooter();
    }

    public void UseVehicles()
    {
        _car.Drive();
        _scooter.Ride();
    }
}
