using DesignPatternsPractice.Structural.Factory.Interface;

namespace DesignPatternsPractice.Structural.Factory;

public class Dog : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Woof! 🐶");
    }
}
