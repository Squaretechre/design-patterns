using System;

namespace DesignPatterns.BryanHansen.ChainOfResponsibility
{
    // ConcreteHandler
    public class Director : Handler
    {
        public override void HandleRequest(Request request)
        {
            if(request.IsForAConference())
            {
                Console.WriteLine("Directors can approve conferences.");
            }
            else
            {
                Console.WriteLine($"Director can't approve:\n{request.ToString()}\n");
                Successor.HandleRequest(request);
            }
        }
    }
}
