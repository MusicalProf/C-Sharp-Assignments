using System;
using Interfaces;

namespace HungryNinja
{
    public class Food : IConsumable
    {
        public string Name { get; set; }
        public int Calories { get; set; }
        // Foods can be spicy or sweet
        public bool IsSpicy { get; set; }
        public bool IsSweet { get; set; }
        // additional method to get the info of the food.
        public void GetInfo()
        {
            Console.WriteLine($"{Name} (Food). Calories: {Calories}. Spicy?: {IsSpicy}, Sweet?: {IsSweet}");
        }
        // add a constructor that takes in all for parameters: Name, Calories, isSpicy, IsSweet
        public Food(string name, int cal, bool spicy, bool sweet)
        {
            Name = name;
            Calories = cal;
            IsSpicy = spicy;
            IsSweet = sweet;
        }
    }
}