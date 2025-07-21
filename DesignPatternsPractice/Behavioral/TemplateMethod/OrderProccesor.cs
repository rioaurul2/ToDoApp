namespace DesignPatternsPractice.Behavioral.TemplateMethod
{
    public abstract class OrderProcessor
    {
        public void ProcessOrder()
        {
            SelectItems();
            MakePayment();
            DeliverItems();
        }

        protected abstract void SelectItems();
        protected abstract void MakePayment();
        protected abstract void DeliverItems();
    }
}
