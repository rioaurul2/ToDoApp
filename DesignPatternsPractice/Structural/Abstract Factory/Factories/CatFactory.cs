using DesignPatternsPractice.Structural.Factory;
using DesignPatternsPractice.Structural.Factory.Interface;

public class CatFactory : IAnimalFactory
{
    public IAnimal CreateAnimal() => new Cat();
    public IHabitat CreateHabitat() => new House();
}
