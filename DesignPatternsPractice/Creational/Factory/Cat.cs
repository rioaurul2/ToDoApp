using DesignPatternsPractice.Creational.Factory.Interface;

namespace DesignPatternsPractice.Creational.Factory;

public class Cat : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Meow! 🐱");
    }
}
