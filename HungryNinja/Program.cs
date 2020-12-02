using System;

namespace HungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet ComfortFoods = new Buffet();
            Ninja Ryu = new Ninja();
            while(Ryu.IsFull == false){
                Ryu.Eat(ComfortFoods.Serve());
            }
        }
    }
}