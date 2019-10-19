using System;

namespace DesignPatterns.GangOfFour.ChainOfResponsibility
{
    // ConcreteHandler
    public class Dialog : Widget
    {
        public Dialog(HelpHandler handler, Topic topic = Topic.NoHelpTopic) : base(null, topic) {
            SetHandler(handler, topic);
        }

        public override void HandleHelp()
        {
            if (HasHelp())
            {
                Console.WriteLine("Dialog\t - So ink, many printing, wow!!");
            }
            else
            {
                MyHelpHandler().HandleHelp();
            }
        }
    }
}
