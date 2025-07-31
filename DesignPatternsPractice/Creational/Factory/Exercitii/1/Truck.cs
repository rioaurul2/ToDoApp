using DesignPatternsPractice.Creational.Factory.Exercitii._1.Interface;

namespace DesignPatternsPractice.Creational.Factory.Exercitii._1;

public class Truck : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Truck engine start");
    }
}
