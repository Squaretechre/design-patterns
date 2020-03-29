using System;
using System.Text;

namespace DesignPatterns.HeadFirst.State.After
{
    public class GumballMachine
    {
        readonly State _soldOutState;
        readonly State _noQuarterState;
        readonly State _hasQuarterState;
        readonly State _soldState;

        State _state;
        int _count = 0;

        public GumballMachine(int numberGumballs)
        {
            _soldOutState = new SoldOutState(this);
            _noQuarterState = new NoQuarterState(this);
            _hasQuarterState = new HasQuarterState(this);
            _soldState = new SoldState(this);
            _count = numberGumballs;

            if (numberGumballs > 0)
            {
                _state = _noQuarterState;
            }
            else
            {
                _state = _soldOutState;
            }
        }

        public void InsertQuarter()
        {
            _state.InsertQuarter();
        }

        public void EjectQuarter()
        {
            _state.EjectQuarter();
        }

        public void TurnCrank()
        {
            _state.TurnCrank();
        }

        public void Dispense()
        {
            _state.Dispense();
        }

        public int GetCount()
        {
            return _count;
        }

        public void Refill(int count)
        {
            _count += count;
            Console.WriteLine("The gumball machine was just refilled; it's new count is: " + this._count);
            _state.Refill();
        }

        public void SetState(State state)
        {
            _state = state;
        }

        public State GetState()
        {
            return _state;
        }

        public State GetSoldOutState()
        {
            return _soldOutState;
        }

        public State GetNoQuarterState()
        {
            return _noQuarterState;
        }

        public State GetHasQuarterState()
        {
            return _hasQuarterState;
        }

        public State GetSoldState()
        {
            return _soldState;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("\nMighty Gumball, Inc.");
            result.Append("\nC#-enabled Standing Gumball Model #2019");
            result.Append("\nInventory: " + _count + " gumball");
            if (_count != 1)
            {
                result.Append("s");
            }
            result.Append("\n");
            result.Append("Machine is " + _state + "\n");
            return result.ToString();
        }
    }
}
