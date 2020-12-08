using System;
using Models;

namespace human
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Human Ramar = new Human("Ra'mar");
            Human Tamster = new Human("Tamster");
            Wizard Mowgli = new Wizard("Mowgli", 40, 30);
            Ninja Ryu = new Ninja("Ryu Hyabusa", 50, 60, 1500);
            Samurai Last = new Samurai("The Last Samurai", 70, 15, 70);

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("#####################");
            Console.WriteLine($"The battle Commences!!");
            Ramar.Attack(Ryu);
            Mowgli.Attack(Ryu);
            Mowgli.Heal(Tamster);
            Ryu.Attack(Tamster);
            Ryu.Attack(Last);
            Last.Meditate();
            Ryu.Steal(Ramar);
            Mowgli.Heal(Ramar);
            Ramar.Attack(Ryu);
            Tamster.Attack(Ryu);
            Last.Attack(Mowgli);
            Console.WriteLine($"The battle has ended!");
            Console.WriteLine("#####################");
            Console.WriteLine("");
            Console.ResetColor();

        }
    }
}
