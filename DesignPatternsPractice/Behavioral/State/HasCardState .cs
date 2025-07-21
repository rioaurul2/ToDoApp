using System;

namespace DesignPatternsPractice.Behavioral.State
{
    public class HasCardState : IAtmState
    {
        private readonly AtmContext _atm;

        public HasCardState(AtmContext atm)
        {
            _atm = atm;
        }

        public void InsertCard()
        {
            Console.WriteLine("❌ Card deja introdus.");
        }

        public void EjectCard()
        {
            Console.WriteLine("✅ Card retras.");
            _atm.SetState(new NoCardState(_atm));
        }

        public void WithdrawCash()
        {
            Console.WriteLine("💸 Retragere efectuată.");
            _atm.SetState(new NoCardState(_atm)); // revine la stare inițială
        }
    }
}
