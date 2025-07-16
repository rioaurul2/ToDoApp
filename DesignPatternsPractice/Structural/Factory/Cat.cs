using DesignPatternsPractice.Structural.Factory.Interface;

namespace DesignPatternsPractice.Structural.Factory;

public class Cat : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Meow! 🐱");
    }
}
