namespace DesignPatternsPractice.Behavioral.ChainOfResponsibility
{
    public class Director : Approver
    {
        public override void Approve(ExpenseRequest request)
        {
            Console.WriteLine($"[Director] Aprobat: {request.Description} ({request.Amount} lei)");
        }
    }
}
