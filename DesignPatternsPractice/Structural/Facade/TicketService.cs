namespace DesignPatternsPractice.Structural.Facade
{
    public class TicketService
    {
        public void ReserveTicket(string eventName)
        {
            Console.WriteLine($"[Ticket] Loc rezervat la evenimentul: {eventName}");
        }
    }
}
