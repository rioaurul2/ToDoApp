namespace DesignPatternsPractice.Behavioral.State
{
    public interface IAtmState
    {
        void InsertCard();
        void EjectCard();
        void WithdrawCash();
    }
}
