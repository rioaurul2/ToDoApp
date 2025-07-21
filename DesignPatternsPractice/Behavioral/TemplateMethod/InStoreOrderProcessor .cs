namespace DesignPatternsPractice.Behavioral.TemplateMethod
{
    public class InStoreOrderProcessor : OrderProcessor
    {
        protected override void SelectItems()
        {
            Console.WriteLine("[Magazin] Produse selectate fizic.");
        }

        protected override void MakePayment()
        {
            Console.WriteLine("[Magazin] Plata cash la casă.");
        }

        protected override void DeliverItems()
        {
            Console.WriteLine("[Magazin] Clientul a preluat produsele.");
        }
    }
}
