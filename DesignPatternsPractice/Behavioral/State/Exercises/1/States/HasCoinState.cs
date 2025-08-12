public class HasCoinState : ITicketState
{
    private readonly TicketMachine _machine;
    public HasCoinState(TicketMachine machine) => _machine = machine;

    public void InsertCoin() => Console.WriteLine("Coin already inserted.");
    public void Select()
    {
        Console.WriteLine("Ticket selected.");
        _machine.SetState(_machine.SoldState);
    }

    public void Dispense() => Console.WriteLine("Select a ticket first.");
}
