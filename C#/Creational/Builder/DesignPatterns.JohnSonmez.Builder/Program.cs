using DesignPatterns.JohnSonmez.Builder.After;

namespace DesignPatterns.JohnSonmez.Builder
{
    public class Program
    {
        public static void Main()
        {
            var builder = new MySandwichBuilder();
            var maker = new SandwichMaker(builder);

            maker.BuildSandwich();

            var sandwich = maker.GetSandwich();

            sandwich.Display();
        }
    }
}
