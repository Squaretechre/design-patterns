using System.Collections.Generic;

namespace DesignPatterns.JohnSonmez.Builder.After
{
    public class ClubSandwichBuilder : SandwichBuilder
    {
        public override void PrepareBread()
        {
            Sandwich.BreadType = BreadType.White;
            Sandwich.IsToasted = true;
        }

        public override void ApplyMeatAndCheese()
        {
            Sandwich.CheeseType = CheeseType.Swiss;
            Sandwich.MeatType = MeatType.Turkey;
        }

        public override void ApplyVegetables()
        {
            Sandwich.Vegetables = new List<string> { "Tomato", "Onion", "Lettuce" };
        }

        public override void AddCondiments()
        {
            Sandwich.HasMayo = true;
            Sandwich.HasMustard = true;
        }
    }
}
