using System;

namespace DesignPatternsPractice.Behavioral.State
{
    public class NoCardState : IAtmState
    {
        private readonly AtmContext _atm;

        public NoCardState(AtmContext atm)
        {
            _atm = atm;
        }

        public void InsertCard()
        {
            Console.WriteLine("✅ Card introdus.");
            _atm.SetState(new HasCardState(_atm));
        }

        public void EjectCard()
        {
            Console.WriteLine("❌ Nu ai introdus niciun card.");
        }

        public void WithdrawCash()
        {
            Console.WriteLine("❌ Introdu mai întâi un card.");
        }
    }
}
