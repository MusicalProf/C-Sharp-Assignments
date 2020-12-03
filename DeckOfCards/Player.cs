using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    class Player
    {
        public string Name;
        public List<Card> Hand;
        public Player(string name)
        {
            Name = name;
            Hand = new List<Card>();
        }
        public Card draw(int num)
        {
            Deck S = new Deck();
            Card card = new Card();
            Console.WriteLine($"{this.Name} drew {num} cards from the deck.");
            S.shuffle();
            for(int i = 0; i < num; i++){
                card = S.deal();
                Hand.Add(card);
                Console.WriteLine($"{this.Name} drew the {card.StringVal} of {card.Suit} and added it to his hand.");
            }
            S.reset();
            return card;
        }
        public Card discard(int idx)
        {
            Card select;
            if (idx > Hand.Count - 1)
                return null;
            else
                select = Hand[idx];
                Hand.Remove(select);
                return select;
        }
    }
}