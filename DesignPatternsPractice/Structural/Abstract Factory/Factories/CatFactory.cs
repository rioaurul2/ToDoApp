using DesignPatternsPractice.Creational.Factory.Interface;
using DesignPatternsPractice.Structural.Factory;

public class CatFactory : IAnimalFactory
{
    public IAnimal CreateAnimal() => new Cat();
    public IHabitat CreateHabitat() => new House();
}
