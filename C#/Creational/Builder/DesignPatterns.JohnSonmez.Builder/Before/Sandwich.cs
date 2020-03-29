using System;
using System.Collections.Generic;

namespace DesignPatterns.JohnSonmez.Builder.Before
{
    public class Sandwich
    {
        private readonly BreadType _breadType;
        private readonly CheeseType _cheeseType;
        private readonly MeatType _meatType;
        private readonly bool _isToasted;
        private readonly bool _hasMustard;
        private readonly bool _hasMayo;
        private readonly List<string> _vegetables;

        // Problem: large constructor
        public Sandwich(
            BreadType breadType,
            CheeseType cheeseType,
            MeatType meatType,
            bool isToasted,
            bool hasMustard,
            bool hasMayo,
            List<string> vegetables
            )
        {
            _breadType = breadType;
            _cheeseType = cheeseType;
            _meatType = meatType;
            _isToasted = isToasted;
            _hasMustard = hasMustard;
            _hasMayo = hasMayo;
            _vegetables = vegetables;
        }

        public void Display()
        {
            Console.WriteLine($"Sandwich on {_breadType}");

            if (_isToasted) Console.WriteLine("Toasted");
            if (_hasMayo) Console.WriteLine("With mayo");
            if (_hasMustard) Console.WriteLine("With mustard");

            Console.WriteLine($"Meat: {_meatType}");
            Console.WriteLine($"Cheese: {_cheeseType}");

            Console.WriteLine($"Veggies:");
            _vegetables.ForEach(vegetable => Console.WriteLine(vegetable));
        }
    }
}
