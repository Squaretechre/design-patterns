using System;

namespace DesignPatterns.GangOfFour.ChainOfResponsibility
{
    // ConcreteHandler
    public class Application : HelpHandler
    {
        public Application(Topic topic) : base(null, topic) { }

        public override void HandleHelp()
        {
            Console.WriteLine("Application\t - Oh no, we reached the application and no help is available!");
        }
    }
}
