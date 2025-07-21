namespace DesignPatternsPractice.Creational.Builder.Interfaces;

public interface IPizzaBuilder
{
    IPizzaBuilder WithSize(string size);
    IPizzaBuilder WithCheese();
    IPizzaBuilder AddToppings(params string[] toppings);
    Pizza Build();
}
