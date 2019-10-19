namespace DesignPatterns.GangOfFour.State
{
    // State
    public abstract class TCPState
    {
        public abstract void Transmit(TCPConnection connection, TCPOctetStream stream);
        public abstract void ActiveOpen(TCPConnection connection);
        public abstract void Close(TCPConnection connection);
        public abstract void PassiveOpen(TCPConnection connection);
        public abstract void Synchronize(TCPConnection connection);
        public abstract void Send(TCPConnection connection);
        public abstract void Acknowledge(TCPConnection connection);

        public void ChangeState(TCPConnection connection, TCPState state)
        {
            connection.ChangeState(state);
        }
    }
}
