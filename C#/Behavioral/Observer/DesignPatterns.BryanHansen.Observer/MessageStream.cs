using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.BryanHansen.Observer
{
    public class MessageStream : Subject
    {
        private readonly List<string> _messageHistory = new List<string>();

        public override void SetState(string message)
        {
            _messageHistory.Add(message);
            NotifyObservers();
        }

        public override string GetState()
        {
            return _messageHistory.Last();
        }
    }
}