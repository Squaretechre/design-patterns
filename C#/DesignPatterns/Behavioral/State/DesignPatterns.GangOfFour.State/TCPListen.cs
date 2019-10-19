namespace DesignPatterns.GangOfFour.State
{
    // ConcreteState
    internal class TCPListen : TCPState
    {
        private static readonly TCPState _instance;

        public static TCPState Instance()
        {
            return _instance ?? new TCPListen();
        }

        public override void Acknowledge(TCPConnection connection)
        {
            // TCPListen specific implementation
        }

        public override void ActiveOpen(TCPConnection connection)
        {
            // TCPListen specific implementation
        }

        public override void Close(TCPConnection connection)
        {
            // TCPListen specific implementation
        }

        public override void PassiveOpen(TCPConnection connection)
        {
            // TCPListen specific implementation
        }

        public override void Send(TCPConnection connection)
        {
            // Send SYN, receive SYN, ACK, etc.
            ChangeState(connection, TCPEstablished.Instance());
        }

        public override void Synchronize(TCPConnection connection)
        {
            // TCPListen specific implementation
        }

        public override void Transmit(TCPConnection connection, TCPOctetStream stream)
        {
            // TCPListen specific implementation
        }
    }
}