using DesignPatternsPractice.Creational.Factory.Exercitii._2.Interfaces;

namespace DesignPatternsPractice.Creational.Factory.Exercitii._2;

public class Truck : IVehiclePark
{
    public void Drive()
    {
        Console.WriteLine("You drive a truck");
    }
}
