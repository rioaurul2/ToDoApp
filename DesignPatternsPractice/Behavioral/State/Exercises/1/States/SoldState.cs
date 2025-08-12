public class SoldState : ITicketState
{
    private readonly TicketMachine _machine;
    public SoldState(TicketMachine machine) => _machine = machine;

    public void InsertCoin() => Console.WriteLine("Please wait, dispensing ticket...");
    public void Select() => Console.WriteLine("Already selected.");
    public void Dispense()
    {
        Console.WriteLine("Dispensing ticket 🎟️");
        _machine.SetState(_machine.NoCoinState);
    }
}