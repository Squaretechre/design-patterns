using System;

namespace DesignPatterns.BryanHansen.Observer
{
    public class TabletClient : Observer
    {
        private readonly Subject _subject;

        public TabletClient(Subject subject)
        {
            _subject = subject;
            _subject.Attach(this);
        }

        public void AddMessage(string message)
        {
            _subject.SetState($"{message} - sent from tablet");
        }

        public override void Update()
        {
            Console.WriteLine($"Tablet stream: {_subject.GetState()}");
        }
    }
}