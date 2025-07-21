namespace DesignPatternsPractice.Behavioral.TemplateMethod
{
    public class OnlineOrderProcessor : OrderProcessor
    {
        protected override void SelectItems()
        {
            Console.WriteLine("[Online] Produse adăugate în coș.");
        }

        protected override void MakePayment()
        {
            Console.WriteLine("[Online] Plata efectuată cu cardul.");
        }

        protected override void DeliverItems()
        {
            Console.WriteLine("[Online] Livrare prin curier rapid.");
        }
    }
}
