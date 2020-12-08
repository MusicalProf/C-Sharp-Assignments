using System;
using Interfaces;

namespace HungryNinja
{
    class SweetTooth : Ninja
    {
        public override bool IsFull
        {
            get
            {
                if (calorieIntake >= 1500)
                {
                    Console.WriteLine("SweetTooth is full! He cannot eat anymore!");
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        // provide override for IsFull (Full at 1500 Calories)
        public override void Consume(IConsumable item)
        {
            // provide override for Consume
            if (IsFull == false)
            {
                if (item.IsSweet == true)
                {
                    item.GetInfo();
                    ConsumptionHistory.Add(item);
                    calorieIntake += item.Calories + 10;
                    Console.WriteLine($"This item is sweet, adding 10 additional calories\nCurrent Calories: {calorieIntake}");
                }
                else
                {
                    item.GetInfo();
                    ConsumptionHistory.Add(item);
                    calorieIntake += item.Calories;
                    Console.WriteLine($"Current Calories: {calorieIntake}");
                }
            }
        }
    }
}

