using System;
using System.Collections.Generic;

namespace HungryNinja
{
    public class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;
        // add a constructor
        public Ninja()
        {
            calorieIntake = 0;
            FoodHistory = new List<Food>();
        }
        // add a public "getter" property called "IsFull
        public bool IsFull
        {
            get
            {
                if (calorieIntake >= 1200)
                {
                    Console.WriteLine("Ninja is full! Cannot eat anymore!");
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        // build out the Eat method
        public void Eat(Food item)
        {
            if (IsFull == false)
            {
                item.GetInfo();
                FoodHistory.Add(item);
                calorieIntake += item.Calories;
                Console.WriteLine($"Current Calories: {calorieIntake}");
            }
        }
    }
}