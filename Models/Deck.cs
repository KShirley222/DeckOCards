using System;
using System.Collections.Generic;

namespace DeckOCards.Models
{
    public class Deck
    {

        private static List<Card> _deck;
        public Deck()
        {
           Reset();
           
        }

        public static void Reset()
        {
            _deck = new List<Card>();
            string[] suits ={"Spade", "Hearts", "Clubs", "Diamonds"};
            string[] stringVal = {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};
            for(int i=0; i<suits.Length; i++)
            {
                for(int j=0; j<stringVal.Length;j++)
                {
                    _deck.Add(
                        new Card(suits[i], stringVal[j], j+1)
                    );
                }
            }
        }

        public Card Draw()
        {
           Card drawCard = _deck[0];
           _deck.RemoveAt(0);
           Console.WriteLine($"You drew a {drawCard.stringVal} of {drawCard.Suit} ");
           return drawCard;
        }

        public void Shuffle()
        {
            Random r = new Random();
            for(int i = 0; i<_deck.Count; i++)
            {
                int rI = r.Next(_deck.Count);
                Card temp = _deck[i];
                _deck[i] = _deck[rI];
                _deck[rI] = temp;
            }
        }
        public void Display()
        {
            foreach(Card card in _deck)
           {
               Console.WriteLine(card.Display());
           }
        }

        public List<Card> Deal(int num)
        {
            List<Card> cards =  new List<Card>();
            while(num > 0){
            Card drawCard = _deck[0];
            _deck.RemoveAt(0);
            cards.Add(drawCard);
            Console.WriteLine($"You drew a {drawCard.stringVal} of {drawCard.Suit} ");
            num--;
            }
            return cards;
        }
    }
}