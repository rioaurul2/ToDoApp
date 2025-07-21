namespace DesignPatternsPractice.Behavioral.State
{
    public class AtmContext
    {
        private IAtmState _currentState;

        public AtmContext()
        {
            _currentState = new NoCardState(this);
        }

        public void SetState(IAtmState state)
        {
            _currentState = state;
        }

        public void InsertCard() => _currentState.InsertCard();
        public void EjectCard() => _currentState.EjectCard();
        public void WithdrawCash() => _currentState.WithdrawCash();
    }
}
