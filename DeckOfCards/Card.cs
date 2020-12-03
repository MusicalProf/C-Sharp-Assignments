namespace DeckOfCards
{
    public class Card
    {
        public string StringVal;
        public string Suit;
        public int Val;

        public Card(string strVal, string suit, int val)
        {
            StringVal = strVal;
            Suit = suit;
            Val = val;
        }
        public Card()
        {
            
        }
    }
}