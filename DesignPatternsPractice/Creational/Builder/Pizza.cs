using DesignPatternsPractice.Structural.Factory;

namespace DesignPatternsPractice.Creational.Builder;

public class Pizza
{
    public string Size { get; set; }
    public bool HasCheese { get; set; }
    public List<string> Toppings { get; set; } = new();

    public override string ToString()
    {
        var toppings = Toppings.Any() ? string.Join(", ", Toppings) : "fără toppinguri";
        return $"Pizza cu blat: {Size}, are cascaval: {HasCheese}, toppinguri: {toppings}";
    }

}
