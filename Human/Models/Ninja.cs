using System;

namespace Models
{
    public class Ninja : Human
    {
        public Ninja(string name, int str, int intel, int hp) : base(name, str, intel, 175, hp)
        {
            Name = name;
            Strength = str;
            Intelligence = intel;
            Health = hp;
        }
        public override int Attack(Human target)
        {
            Random rand = new Random();
            int chance = rand.Next(0, 100);
            int PDmg = 5 * this.Dexterity;
            if (chance <= 20)
            {
                PDmg += 10;
                target.Health -= PDmg;
                Console.WriteLine($"{this.Name} increased his luck and attacked {target.Name} for an additional 10 points of damage!\n{this.Name} dealt {PDmg} points of Physical damage to {target.Name}, who now has {target.Health}HP remaining!");
            }
            else
            {
                target.Health -= PDmg;
                Console.WriteLine($"{this.Name} attacked {target.Name} and dealt {PDmg} points of Physical damage!");
                Console.WriteLine($"{target.Name} has {target.Health}HP remaining!");
            }
            return target.Health;
        }
        public int Steal(Human target)
        {
            int healthStolen = 50;
            target.Health -= healthStolen;
            this.Health += healthStolen;
            Console.WriteLine($"{this.Name} snatched {healthStolen}HP from {target.Name} and healed himself using his ninjustu!\n{this.Name} now has {this.Health}HP while {target.Name} suffers with {target.Health}HP");
            return healthStolen;
        }
    }
}