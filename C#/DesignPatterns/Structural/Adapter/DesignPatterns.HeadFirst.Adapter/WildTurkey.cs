using System;

namespace DesignPatterns.HeadFirst.Adapter
{
    public class WildTurkey : Turkey
    {
        public void Fly()
        {
            Console.WriteLine("[Turkey] I'm flying a short distance.");
        }

        public void Gobble()
        {
            Console.WriteLine("[Turkey] Gobble gobble.");
        }
    }
}
