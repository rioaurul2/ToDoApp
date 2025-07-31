using DesignPatternsPractice.Creational.Factory.Interface;
using DesignPatternsPractice.Structural.Factory;

public class DogFactory : IAnimalFactory
{
    public IAnimal CreateAnimal() => new Dog();
    public IHabitat CreateHabitat() => new Kennel();
}
