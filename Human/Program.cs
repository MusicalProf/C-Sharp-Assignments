using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Human Ramar = new Human("Ra'mar");
            Human Target = new Human("Tamster");

            Ramar.Attack(Target);
        }
    }
}
