using DesignPatternsPractice.Creational.Abstract_Factory.Exercitii._1.Interfaces;

public class EconomyVehicleFactory : IVehicleFactory
{
    public ICar CreateCar() => new EconomyCar();
    public IScooter CreateScooter() => new EconomyScooter();
}
