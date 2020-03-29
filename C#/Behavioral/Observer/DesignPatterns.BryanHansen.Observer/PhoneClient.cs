using System;

namespace DesignPatterns.BryanHansen.Observer
{
    public class PhoneClient : Observer
    {
        private readonly Subject _subject;

        public PhoneClient(Subject subject)
        {
            _subject = subject;
            subject.Attach(this);
        }

        public void AddMessage(string message)
        {
            _subject.SetState($"{message} - sent from phone");
        }

        public override void Update()
        {
            Console.WriteLine($"Phone stream: {_subject.GetState()}");
        }
    }
}