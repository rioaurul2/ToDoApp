namespace DesignPatternsPractice.Behavioral.ChainOfResponsibility
{
    public class Manager : Approver
    {
        public override void Approve(ExpenseRequest request)
        {
            if (request.Amount <= 5000)
            {
                Console.WriteLine($"[Manager] Aprobat: {request.Description} ({request.Amount} lei)");
            }
            else
            {
                NextApprover?.Approve(request);
            }
        }
    }
}
