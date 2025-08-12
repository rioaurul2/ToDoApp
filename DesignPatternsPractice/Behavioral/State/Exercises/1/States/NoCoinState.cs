public class NoCoinState : ITicketState
{
    private readonly TicketMachine _machine;
    public NoCoinState(TicketMachine machine) => _machine = machine;

    public void InsertCoin()
    {
        Console.WriteLine("Coin inserted.");
        _machine.SetState(_machine.HasCoinState);
    }

    public void Select() => Console.WriteLine("Insert coin first.");
    public void Dispense() => Console.WriteLine("Cannot dispense without coin.");
}