using System;

namespace HungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet ComfortFoods = new Buffet();
            SweetTooth Ryu = new SweetTooth();
            SpiceHound Naruto = new SpiceHound();
            while (Ryu.IsFull == false)
            {
                Ryu.Consume(ComfortFoods.Serve());
            }
            while (Naruto.IsFull == false)
            {
                Naruto.Consume(ComfortFoods.Serve());
            }
            if (Ryu.ConsumptionHistory.Count > Naruto.ConsumptionHistory.Count)
            {
                Console.WriteLine($"Ryu's Sweetooth overwhelmed Naruto's SpiceHound!! Sweetooth Wins!");
            }
            else
            {
                Console.WriteLine($"Naruto's SpiceHound blazed through Ryu's Sweetooth!! SpiceHound Wins!");
            }
        }
    }
}