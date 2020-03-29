using System;

namespace DesignPatterns.BryanHansen.Observer
{
    public class ObserverDemo
    {
        public static void Main()
        {
            Subject subject = new MessageStream();

            var phoneClient = new PhoneClient(subject);
            var tabletClient = new TabletClient(subject);

            phoneClient.AddMessage("Here is a new message!");
            tabletClient.AddMessage("Another new message!");

            Console.WriteLine();
        }
    }
}