namespace DesignPatterns.GangOfFour.ChainOfResponsibility
{
    // ConcreteHandler
    public class Widget : HelpHandler
    {
        protected Widget _parent;

        public Widget(Widget widget, Topic topic) : base(widget, topic) {
            _parent = widget;
        }
    }
}
