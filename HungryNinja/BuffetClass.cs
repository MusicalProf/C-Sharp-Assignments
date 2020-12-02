using System;
using System.Collections.Generic;

namespace HungryNinja
{
    public class Buffet
    {
        public List<Food> Menu;

        // constructor
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Scrambled Eggs", 350, false, false),
                new Food("Pancakes", 300, false, true),
                new Food("Gumbo", 450, true, false),
                new Food("Kiwi", 200, false, true),
                new Food("Chicken Noodle Soup", 300, false, false),
                new Food("Grilled Mahi Mahi", 550, false, true),
                new Food("Cheeseburger", 650, false, false)
            };
        }
        public Food Serve()
        {
            Random menuChoice = new Random();
            int num = menuChoice.Next(0, Menu.Count);
            Food selection = Menu[num];
            return selection;
        }
    }
}