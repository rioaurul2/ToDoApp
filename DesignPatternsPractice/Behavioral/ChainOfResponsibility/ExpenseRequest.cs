namespace DesignPatternsPractice.Behavioral.ChainOfResponsibility
{
    public class ExpenseRequest
    {
        public string Description { get; }
        public decimal Amount { get; }

        public ExpenseRequest(string description, decimal amount)
        {
            Description = description;
            Amount = amount;
        }
    }
}
