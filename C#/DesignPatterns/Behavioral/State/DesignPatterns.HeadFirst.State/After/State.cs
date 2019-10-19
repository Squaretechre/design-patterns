namespace DesignPatterns.HeadFirst.State.After
{
    public interface State
    {
        void InsertQuarter();
        void EjectQuarter();
        void TurnCrank();
        void Dispense();
        void Refill();
    }
}
