using System;

namespace DesignPatterns.BryanHansen.ChainOfResponsibility
{
    // ConcreteHandler
    public class VP : Handler
    {
        public override void HandleRequest(Request request)
        {
            if (request.IsASmallPurchase())
            {
                Console.WriteLine("VPs can approve purchases below £1,500");
            }
            else
            {
                Console.WriteLine($"VP can't approve:\n{request.ToString()}\n");
                Successor.HandleRequest(request);
            }
        }
    }
}
