using System;
using System.Text;

namespace DesignPatterns.HeadFirst.State.Before
{
    public class GumballMachine
    {
        static readonly int SOLD_OUT = 0;
        static readonly int NO_QUARTER = 1;
        static readonly int HAS_QUARTER = 2;
        static readonly int SOLD = 3;

        int _state = SOLD_OUT;
        int _count = 0;

        public GumballMachine(int count)
        {
            _count = count;
            if (count > 0)
            {
                _state = NO_QUARTER;
            }
        }

        public void InsertQuarter()
        {
            if (_state == HAS_QUARTER)
            {
                Console.WriteLine("You can't insert another quarter");
            }
            else if (_state == NO_QUARTER)
            {
                _state = HAS_QUARTER;
                Console.WriteLine("You inserted a quarter");
            }
            else if (_state == SOLD_OUT)
            {
                Console.WriteLine("You can't insert a quarter, the machine is sold out");
            }
            else if (_state == SOLD)
            {
                Console.WriteLine("Please wait, we're already giving you a gumball");
            }
        }

        public void EjectQuarter()
        {
            if (_state == HAS_QUARTER)
            {
                Console.WriteLine("Quarter returned");
                _state = NO_QUARTER;
            }
            else if (_state == NO_QUARTER)
            {
                Console.WriteLine("You haven't inserted a quarter");
            }
            else if (_state == SOLD)
            {
                Console.WriteLine("Sorry, you already turned the crank");
            }
            else if (_state == SOLD_OUT)
            {
                Console.WriteLine("You can't eject, you haven't inserted a quarter yet");
            }
        }

        public void TurnCrank()
        {
            if (_state == SOLD)
            {
                Console.WriteLine("Turning twice doesn't get you another gumball!");
            }
            else if (_state == NO_QUARTER)
            {
                Console.WriteLine("You turned but there's no quarter");
            }
            else if (_state == SOLD_OUT)
            {
                Console.WriteLine("You turned, but there are no gumballs");
            }
            else if (_state == HAS_QUARTER)
            {
                Console.WriteLine("You turned...");
                _state = SOLD;
                Dispense();
            }
        }

        private void Dispense()
        {
            if (_state == SOLD)
            {
                Console.WriteLine("A gumball comes rolling out the slot");
                _count = _count - 1;
                if (_count == 0)
                {
                    Console.WriteLine("Oops, out of gumballs!");
                    _state = SOLD_OUT;
                }
                else
                {
                    _state = NO_QUARTER;
                }
            }
            else if (_state == NO_QUARTER)
            {
                Console.WriteLine("You need to pay first");
            }
            else if (_state == SOLD_OUT)
            {
                Console.WriteLine("No gumball dispensed");
            }
            else if (_state == HAS_QUARTER)
            {
                Console.WriteLine("No gumball dispensed");
            }
        }

        public void Refill(int numGumBalls)
        {
            _count = numGumBalls;
            _state = NO_QUARTER;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("\nMighty Gumball, Inc.");
            result.Append("\nC#-enabled Standing Gumball Model #2019\n");
            result.Append("Inventory: " + _count + " gumball");
            if (_count != 1)
            {
                result.Append("s");
            }
            result.Append("\nMachine is ");
            if (_state == SOLD_OUT)
            {
                result.Append("sold out");
            }
            else if (_state == NO_QUARTER)
            {
                result.Append("waiting for quarter");
            }
            else if (_state == HAS_QUARTER)
            {
                result.Append("waiting for turn of crank");
            }
            else if (_state == SOLD)
            {
                result.Append("delivering a gumball");
            }
            result.Append("\n");
            return result.ToString();
        }
    }
}
