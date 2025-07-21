namespace DesignPatternsPractice.Structural.Facade
{
    public class BookingFacade
    {
        private readonly PaymentService _paymentService = new();
        private readonly TicketService _ticketService = new();
        private readonly EmailService _emailService = new();

        public void BookTicket(string user, string eventName)
        {
            _paymentService.ProcessPayment(user);
            _ticketService.ReserveTicket(eventName);
            _emailService.SendConfirmation(user);
        }
    }
}
