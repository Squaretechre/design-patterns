using System;

namespace DesignPatterns.GangOfFour.ChainOfResponsibility
{
    // ConcreteHandler
    public class Button : Widget
    {
        public Button(Widget widget, Topic topic = Topic.NoHelpTopic) : base(widget, topic) { }

        public override void HandleHelp()
        {
            if(HasHelp())
            {
                Console.WriteLine("Button\t - Such paper, much orientation, wow!");
            }
            else
            {
                MyHelpHandler().HandleHelp();
            }
        }
    }
}
