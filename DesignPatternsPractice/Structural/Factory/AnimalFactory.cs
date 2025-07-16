using DesignPatternsPractice.Structural.Factory.Interface;

namespace DesignPatternsPractice.Structural.Factory;

public static class AnimalFactory
{
    public static IAnimal CreateAnimal(string animalType)
    {
        return animalType.ToLower() switch
        {
            "dog" => new Dog(),
            "cat" => new Cat(),
            _ => throw new ArgumentException("Invalid animal type")
        };
    }
}

/*

Interfața definește contractul (IAnimal).

Clasele concrete (Dog, Cat) implementează comportamentul.

Factory-ul (AnimalFactory) decide ce clasă să instanțieze.

Codul client (Program) nu știe ce clasă exactă creează — doar că primește un IAnimal.

*/
