using System;
using System.Collections.Generic;
using Interfaces;

namespace HungryNinja
{
    public class Buffet
    {
        public List<IConsumable> Menu;

        // constructor
        public Buffet()
        {
            Menu = new List<IConsumable>()
            {
                new Food("Scrambled Eggs", 350, false, false),
                new Food("Pancakes", 300, false, true),
                new Food("Gumbo", 450, true, false),
                new Food("Kiwi", 200, false, true),
                new Food("Chicken Noodle Soup", 300, false, false),
                new Food("Grilled Mahi Mahi", 550, false, true),
                new Food("Cheeseburger", 650, false, false),
                new Drink("Lemonade", 300, false),
                new Drink("Ginger Beer", 180, true),
                new Drink("Cran-Pomegranate", 350, false),
                new Drink("Sierra Mist", 210, false),
                new Drink("Virgin Mary", 30, true)
            };
        }
        public IConsumable Serve()
        {
            Random menuChoice = new Random();
            int num = menuChoice.Next(0, Menu.Count);
            IConsumable selection = Menu[num];
            return selection;
        }
    }
}