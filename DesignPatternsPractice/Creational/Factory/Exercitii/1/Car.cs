using DesignPatternsPractice.Creational.Factory.Exercitii._1.Interface;

namespace DesignPatternsPractice.Creational.Factory.Exercitii._1;

public class Car : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Start car engine");
    }
}
