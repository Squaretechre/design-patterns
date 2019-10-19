namespace DesignPatterns.BryanHansen.ChainOfResponsibility
{
    // Handler
    public abstract class Handler
    {
        protected Handler Successor;

        public abstract void HandleRequest(Request request);

        public void SetSuccessor(Handler successor) => Successor = successor;
    }
}
