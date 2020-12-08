using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck D = new Deck();
            // D.shuffle();
            Card C = new Card();
            Console.WriteLine($"The card dealt is {C.StringVal} of {C.Suit}");
            Player One = new Player("Ra'mar");
            One.draw(13);
        }
    }
}
