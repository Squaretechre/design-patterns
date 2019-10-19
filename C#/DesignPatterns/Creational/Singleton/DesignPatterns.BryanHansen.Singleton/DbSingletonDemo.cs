using System;

namespace DesignPatterns.BryanHansen.Singleton
{
    public class DbSingletonDemo
    {
        public static void Main()
        {
            var instance = DbSingleton.GetInstance;

            Console.WriteLine(instance.GetHashCode());

            var anotherInstance = DbSingleton.GetInstance;

            Console.WriteLine(anotherInstance.GetHashCode());

            Console.ReadLine();
        }
    }
}
