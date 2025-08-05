using DesignPatternsPractice.Creational.Factory;
using DesignPatternsPractice.Creational.Factory.Interface;

public class CatFactory : IAnimalFactory
{
    public IAnimal CreateAnimal() => new Cat();
    public IHabitat CreateHabitat() => new House();
}
