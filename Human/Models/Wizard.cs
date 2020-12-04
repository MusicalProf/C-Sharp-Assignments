using System;

namespace Models
{
    public class Wizard : Human
    {
        public Wizard(string name, int str, int dex) : base(name, str, 25, dex, 500)
        {
            Name = name;
            Strength = str;
            Dexterity = dex;
        }
        public override int Attack(Human target)
        {
            int MDmg = 5 * this.Intelligence;
            target.Health = target.Health - MDmg;
            this.Health = Health + MDmg;
            Console.WriteLine($"{this.Name} attacks {target.Name} for {MDmg} points of Magic Damage!\n{target.Name} has {target.Health}HP remaining.\n{this.Name}'s powers of healing kick in after an attack, and heals him for {MDmg}HP! They now have {this.Health} HP!");
            return target.Health;
        }
        public int Heal(Human target)
        {
            int heal = 10 * this.Intelligence;
            target.Health += heal;
            Console.WriteLine($"{this.Name} used his potent magic to heal {target.Name} for {heal}HP. {target.Name} now has {target.Health}HP.");
            return target.Health;
        }
    }
}
