using DesignPatternsPractice.Structural.Factory;
using DesignPatternsPractice.Structural.Factory.Interface;

public class DogFactory : IAnimalFactory
{
    public IAnimal CreateAnimal() => new Dog();
    public IHabitat CreateHabitat() => new Kennel();
}
