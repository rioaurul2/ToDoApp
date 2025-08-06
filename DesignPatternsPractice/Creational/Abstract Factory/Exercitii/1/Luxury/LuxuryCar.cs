using DesignPatternsPractice.Creational.Abstract_Factory.Exercitii._1.Interfaces;

namespace DesignPatternsPractice.Creational.Abstract_Factory.Exercitii._1.Luxury;

public class LuxuryCar : ICar
{
    public void Drive()
    {
        Console.WriteLine("Driving a luxury car");
    }
}
