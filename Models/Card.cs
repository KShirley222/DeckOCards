namespace DeckOCards.Models
{
    public class Card
    {
        public string Suit{get;}
        public string stringVal{get;}
        public int Value{get;}

        public Card(string st, string stvl, int vl)
        {
            Suit = st;
            stringVal = stvl;
            Value = vl;

        }

        public string Display(){
            return $"The {stringVal} of {Suit}";
        }


    }
}