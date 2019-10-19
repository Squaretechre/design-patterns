using System;

namespace DesignPatterns.BryanHansen.ChainOfResponsibility
{
    // ConcreteHandler
    public class CEO : Handler
    {
        public override void HandleRequest(Request request)
        {
            Console.WriteLine("CEOs can approve anything they want.");
        }
    }
}
