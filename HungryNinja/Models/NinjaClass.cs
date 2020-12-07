using System;
using Interfaces;
using System.Collections.Generic;

namespace HungryNinja
{
    public abstract class Ninja
    {
        protected int calorieIntake;
        public List<IConsumable> ConsumptionHistory;
        // add a constructor
        public Ninja()
        {
            calorieIntake = 0;
            ConsumptionHistory = new List<IConsumable>();
        }
        // add a public "getter" property called "IsFull
        public abstract bool IsFull { get; }

        // build out the Eat method
        public abstract void Consume(IConsumable item);
    }
}