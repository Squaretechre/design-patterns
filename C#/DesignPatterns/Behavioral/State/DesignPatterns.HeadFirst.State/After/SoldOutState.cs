using System;

namespace DesignPatterns.HeadFirst.State.After
{
    class SoldOutState : State
    {
        readonly GumballMachine _gumballMachine;

        public SoldOutState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert a quarter, the machine is sold out");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You can't eject, you haven't inserted a quarter yet");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned, but there are no gumballs");
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }

        public void Refill()
        {
            _gumballMachine.SetState(_gumballMachine.GetNoQuarterState());
        }

        public override string ToString()
        {
            return "sold out";
        }
    }
}
