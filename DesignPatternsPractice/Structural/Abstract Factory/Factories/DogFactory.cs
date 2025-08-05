using DesignPatternsPractice.Creational.Factory;
using DesignPatternsPractice.Creational.Factory.Interface;

public class DogFactory : IAnimalFactory
{
    public IAnimal CreateAnimal() => new Dog();
    public IHabitat CreateHabitat() => new Kennel();
}
