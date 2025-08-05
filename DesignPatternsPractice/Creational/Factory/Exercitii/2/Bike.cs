using DesignPatternsPractice.Creational.Factory.Exercitii._2.Interfaces;

namespace DesignPatternsPractice.Creational.Factory.Exercitii._2;

public class Bike : IVehiclePark
{
    public void Drive()
    {
        Console.WriteLine("You drive a bike");
    }
}
