namespace DesignPatternsPractice.Behavioral.ChainOfResponsibility
{
    public class TeamLeader : Approver
    {
        public override void Approve(ExpenseRequest request)
        {
            if (request.Amount <= 500)
            {
                Console.WriteLine($"[TeamLeader] Aprobat: {request.Description} ({request.Amount} lei)");
            }
            else
            {
                NextApprover?.Approve(request);
            }
        }
    }
}
