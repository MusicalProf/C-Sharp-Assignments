using System;

namespace Human
{
    public class Human
    {
        // Fields for Human
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;

        // add a public "getter" property to access health
        public int Health
        {
            get { return health; }
        }
        // Add a constructor that takes a value to set Name, and set the remaining fields to default values
        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }
        // Add a constructor to assign custom values to all fields
        public Human(string name, int str, int intel, int dex, int hp)
        {
            Name = name;
            Strength = str;
            Intelligence = intel;
            Dexterity = dex;
            health = hp;
        }

        // Build Attack method
        public int Attack(Human target)
        {
            int damage = this.Strength * 5;
            target.health -= damage;
            Console.WriteLine($"{this.Name} attacked {target.Name} and did {damage} hitpoints of damage!!!\n{target.Name} has {target.health} hp remaining!");            
            return target.health;
        }
    }
}