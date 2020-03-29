using System.Collections.Generic;

namespace DesignPatterns.JohnSonmez.Builder.After
{
    public class MySandwichBuilder : SandwichBuilder
    {
        public override void PrepareBread()
        {
            Sandwich.BreadType = BreadType.White;
            Sandwich.IsToasted = true;
        }

        public override void ApplyMeatAndCheese()
        {
            Sandwich.CheeseType = CheeseType.Cheddar;
            Sandwich.MeatType = MeatType.Turkey;
        }

        public override void ApplyVegetables()
        {
            Sandwich.Vegetables = new List<string> { "Tomato", "Onion" };
        }

        public override void AddCondiments()
        {
            Sandwich.HasMayo = false;
            Sandwich.HasMustard = true;
        }
    }
}
