using DesignPatternsPractice.Creational.Factory.Interface;

namespace DesignPatternsPractice.Creational.Factory;

public class Dog : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Woof! 🐶");
    }
}
