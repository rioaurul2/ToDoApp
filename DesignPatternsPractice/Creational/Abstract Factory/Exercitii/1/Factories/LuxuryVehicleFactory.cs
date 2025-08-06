using DesignPatternsPractice.Creational.Abstract_Factory.Exercitii._1.Interfaces;
using DesignPatternsPractice.Creational.Abstract_Factory.Exercitii._1.Luxury;

public class LuxuryVehicleFactory : IVehicleFactory
{
    public ICar CreateCar() => new LuxuryCar();
    public IScooter CreateScooter() => new LuxuryScooter();
}