using System;

namespace HungryNinja
{
    public class Food
    {
        public string Name;
        public int Calories;
        // Foods can be spicy or sweet
        public bool IsSpicy;
        public bool IsSweet;
        // additional method to get the info of the food.
        public void GetInfo()
        {
            Console.WriteLine($"Food Item: {Name}. Calories: {Calories}. Spicy?: {IsSpicy}, Sweet?: {IsSweet}");
        }
        // add a constructor that takes in all for parameters: Name, Calories, isSpicy, IsSweet
        public Food(string name, int cal, bool spicy, bool sweet){
            Name = name;
            Calories = cal;
            IsSpicy = spicy;
            IsSweet = sweet;
        }
    }
}