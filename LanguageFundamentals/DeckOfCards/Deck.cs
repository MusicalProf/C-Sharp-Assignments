using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    class Deck
    {
        public List<Card> cards;
        public string[] value = new string[] {"Ace", "Two", "Three", "Four", "Five", "Six", "Seven",
        "Eight", "Nine", "Ten", "Jack", "Queen", "King"};
        public string[] suit = new string[] { "Clubs", "Spades", "Hearts", "Diamonds" };
        public int[] number = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
        public Deck()
        {
            cards = new List<Card>();
            foreach (string type in suit)
            {
                int val = 1;
                foreach (var rank in value)
                {
                    cards.Add(new Card(rank, type, val++));
                }
            }
        }
        public Card deal()
        {
            Card dealt = cards[0];
            cards.Remove(dealt);
            return dealt;
        }
        public void reset()
        {
            cards = new List<Card>();
            foreach (string type in suit)
            {
                int val = 0;
                foreach (var rank in value)
                {
                    cards.Add(new Card(rank, type, val++));
                }
            }
        }
        public void shuffle()
        {
            Random rand = new Random();
            int idx = 0;
            while (idx < cards.Count)
            {
                Card temp = cards[idx];
                Card newIdx = cards[rand.Next(0, cards.Count)];
                cards[idx] = newIdx;
                newIdx = temp;
                idx++;
            }
        }
    }
}