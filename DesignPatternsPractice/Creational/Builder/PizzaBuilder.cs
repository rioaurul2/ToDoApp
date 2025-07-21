using DesignPatternsPractice.Creational.Builder.Interfaces;

namespace DesignPatternsPractice.Creational.Builder
{
    public class PizzaBuilder : IPizzaBuilder
    {
        private readonly Pizza _pizza = new();

        public IPizzaBuilder WithSize(string size)
        {
            _pizza.Size = size;
            return this;
        }

        public IPizzaBuilder WithCheese()
        {
            _pizza.HasCheese = true;
            return this;
        }

        public IPizzaBuilder AddToppings(params string[] toppings)
        {
            _pizza.Toppings.AddRange(toppings);
            return this;
        }

        public Pizza Build() => _pizza;
    }
}
