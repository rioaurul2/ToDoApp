using DesignPatternsPractice.Creational.Factory.Interface;

public interface IAnimalFactory
{
    IAnimal CreateAnimal();
    IHabitat CreateHabitat();
}
/*

Creezi obiecte compatibile între ele (Dog cu Kennel, Cat cu House).

Clientul (Program) nu știe ce clase concrete sunt folosite.

Adăugarea unei noi familii de obiecte (ex: Bird + Nest) implică doar o nouă fabrică.

*/