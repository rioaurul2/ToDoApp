public class TicketMachine
{
    private ITicketState _state;

    // Stările reutilizabile (opțional singleton-uri interne)
    public readonly ITicketState NoCoinState;
    public readonly ITicketState HasCoinState;
    public readonly ITicketState SoldState;

    public TicketMachine()
    {
        NoCoinState = new NoCoinState(this);
        HasCoinState = new HasCoinState(this);
        SoldState = new SoldState(this);
        _state = NoCoinState;
    }

    public void SetState(ITicketState state) => _state = state;

    // API public – delegăm în starea curentă
    public void InsertCoin() => _state.InsertCoin();
    public void Select() => _state.Select();
    public void Dispense() => _state.Dispense();
}
