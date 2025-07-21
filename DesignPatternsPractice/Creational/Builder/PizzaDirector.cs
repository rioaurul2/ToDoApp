using DesignPatternsPractice.Creational.Builder.Interfaces;

namespace DesignPatternsPractice.Creational.Builder
{
    public class PizzaDirector
    {
        public Pizza BuildMargherita(IPizzaBuilder builder)
        {
            return builder
                .WithSize("XL")
                .WithCheese()
                .AddToppings(["Mozzarella", "Ananas"])
                .Build();
        }

        public Pizza BuildPepperoni(IPizzaBuilder builder)
        {
            return builder
                .WithSize("L")
                .AddToppings(["pepperoni"])
                .Build();
        }
    }
}
