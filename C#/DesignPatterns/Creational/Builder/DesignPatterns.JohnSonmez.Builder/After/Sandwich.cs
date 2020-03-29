using System;
using System.Collections.Generic;

namespace DesignPatterns.JohnSonmez.Builder.After
{
    public class Sandwich
    {
        public BreadType BreadType { get; set; }
        public CheeseType CheeseType { get; set; }
        public MeatType MeatType { get; set; }
        public bool IsToasted { get; set; }
        public bool HasMustard { get; set; }
        public bool HasMayo { get; set; }
        public List<string> Vegetables { get; set; }

        public void Display()
        {
            Console.WriteLine($"Sandwich on {BreadType}");

            if (IsToasted) Console.WriteLine("Toasted");
            if (HasMayo) Console.WriteLine("With mayo");
            if (HasMustard) Console.WriteLine("With mustard");

            Console.WriteLine($"Meat: {MeatType}");
            Console.WriteLine($"Cheese: {CheeseType}");

            Console.WriteLine($"Veggies:");
            Vegetables.ForEach(vegetable => Console.WriteLine(vegetable));
        }
    }
}
