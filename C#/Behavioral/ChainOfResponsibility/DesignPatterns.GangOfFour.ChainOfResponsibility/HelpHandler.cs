namespace DesignPatterns.GangOfFour.ChainOfResponsibility
{
    // Handler
    // Common interface / contract for all handlers (links in the chain)
    public class HelpHandler
    {
        private HelpHandler _successor;
        private Topic _topic;

        public HelpHandler(HelpHandler successor, Topic topic = Topic.NoHelpTopic)
        {
            _successor = successor;
            _topic = topic;
        }

        protected HelpHandler MyHelpHandler()
        {
            return new HelpHandler(_successor, _topic);
        }

        public virtual void SetHandler(HelpHandler successor, Topic topic)
        {
            _successor = successor;
            _topic = topic;
        }

        public virtual bool HasHelp()
        {
            return _topic != Topic.NoHelpTopic;
        }

        public virtual void HandleHelp()
        {
            if (_successor != null)
            {
                _successor.HandleHelp();
            }
        }
    }
}
