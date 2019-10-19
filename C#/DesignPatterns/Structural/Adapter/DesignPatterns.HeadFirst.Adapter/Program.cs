using System;

namespace DesignPatterns.HeadFirst.Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var duck = new MallardDuck();
            var turkey = new WildTurkey();
            var turkeyAdapter = new TurkeyAdapter(turkey);

            Console.WriteLine("The turkey says...");
            turkey.Gobble();
            turkey.Fly();

            Console.WriteLine("\n\nThe duck says...");
            TestDuck(duck);

            Console.WriteLine("\n\nThe turkey adapter says...");
            TestDuck(turkeyAdapter);

            Console.ReadKey();
        }

        private static void TestDuck(Duck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}
