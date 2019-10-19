using System;

namespace DesignPatterns.HeadFirst.Adapter
{
    public class MallardDuck : Duck
    {
        public void Fly()
        {
            Console.WriteLine("[Duck] I'm flying.");
        }

        public void Quack()
        {
            Console.WriteLine("[Duck] Quack!");
        }
    }
}
