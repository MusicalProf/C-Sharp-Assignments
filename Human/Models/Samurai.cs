using System;

namespace Models
{
    public class Samurai : Human
    {
        public Samurai(string name, int str, int intel, int dex) : base(name, str, intel, dex, 2000)
        {
            Name = name;
            Strength = str;
            Intelligence = intel;
            Dexterity = dex;
        }
        public override int Attack(Human target)
        {
            base.Attack(target);
            if (target.Health < 500)
            {
                Console.WriteLine($"{this.Name} executes {target.Name}!");
                target.Health *= 0;
            }
            return target.Health;
        }
        public int Meditate()
        {
            if (this.Health < 2000)
            {
                this.Health = 2000;
            }
            Console.WriteLine($"{this.Name} invoked his power of meditation to heal his wounds and was restored to full health of {this.Health}HP!");
            return Health;
        }
    }
}