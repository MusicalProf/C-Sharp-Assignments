using System;
using Interfaces;

namespace HungryNinja
{
    class SpiceHound : Ninja
    {
        // provide override for IsFull (Full at 1200 Calories)
        public override bool IsFull
        {
            get
            {
                if (calorieIntake >= 1200)
                {
                    Console.WriteLine("SpiceHound is full! He cannot eat anymore");
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public override void Consume(IConsumable item)
        {
            // provide override for Consume
            if (IsFull == false)
            {
                if (item.IsSpicy == true)
                {
                    item.GetInfo();
                    ConsumptionHistory.Add(item);
                    calorieIntake += item.Calories - 5;
                    Console.WriteLine($"This item is spicy, subtracting 5 calories.\nCurrent Calories: {calorieIntake}");
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

