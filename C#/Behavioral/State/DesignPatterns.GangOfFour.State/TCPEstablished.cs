namespace DesignPatterns.GangOfFour.State
{
    // ConcreteState
    internal class TCPEstablished : TCPState
    {
        private static readonly TCPState _instance;

        public static TCPState Instance()
        {
            return _instance ?? new TCPEstablished();
        }

        public override void Acknowledge(TCPConnection connection)
        {
            // TCPEstablished specific implementation
        }

        public override void ActiveOpen(TCPConnection connection)
        {
            // TCPEstablished specific implementation
        }

        public override void Close(TCPConnection connection)
        {
            // Send FIN, receive ACK of FIN

            ChangeState(connection, TCPListen.Instance());
        }

        public override void PassiveOpen(TCPConnection connection)
        {
            // TCPEstablished specific implementation
        }

        public override void Send(TCPConnection connection)
        {
            // TCPEstablished specific implementation
        }

        public override void Synchronize(TCPConnection connection)
        {
            // TCPEstablished specific implementation
        }

        public override void Transmit(TCPConnection connection, TCPOctetStream stream)
        {
            // TCPEstablished specific implementation

            connection.ProcessOctet(stream);
        }
    }
}