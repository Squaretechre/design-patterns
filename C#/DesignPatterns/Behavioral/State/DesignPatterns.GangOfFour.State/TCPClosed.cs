namespace DesignPatterns.GangOfFour.State
{
    // ConcreteState
    public class TCPClosed : TCPState
    {
        private static readonly TCPState _instance;

        public static TCPState Instance()
        {
            return _instance ?? new TCPClosed();
        }

        public override void Acknowledge(TCPConnection connection)
        {
            // TCPClosed specific implementation
        }

        public override void ActiveOpen(TCPConnection connection)
        {
            // Send SYN, receive SYN, ACK, etc.
            ChangeState(connection, TCPEstablished.Instance());
        }

        public override void Close(TCPConnection connection)
        {
            ChangeState(connection, TCPListen.Instance());
        }

        public override void PassiveOpen(TCPConnection connection)
        {
            // TCPClosed specific implementation
        }

        public override void Send(TCPConnection connection)
        {
            // TCPClosed specific implementation
        }

        public override void Synchronize(TCPConnection connection)
        {
            // TCPClosed specific implementation
        }

        public override void Transmit(TCPConnection connection, TCPOctetStream stream)
        {
            // TCPClosed specific implementation
        }
    }
}
