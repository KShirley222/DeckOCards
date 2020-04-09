using System;
using System.Collections.Generic;

namespace DeckOCards.Models
{
    public class Player
    {
        public string Name;
        private static List<Card> _hand;
        private Deck _deckInstance;
        public Player(Deck deckInstance, string name = "Tom")
        {
            Name = name;
            _hand = new List<Card>();
            _deckInstance = deckInstance;
        }

        public void DrawCards(int num=1)
        {
            List<Card> newCards = _deckInstance.Deal(num);
            foreach(Card card in newCards)
            {
                _hand.Add(card);
            }
        }

        public void Display()
        {
            Console.WriteLine($"{Name} is holding {_hand.Count} card(s)");
            foreach(Card card in _hand)
            {
                Console.WriteLine( card.Display() );
            }
        }

        public Card Discard(int num)
        {
            Card card = _hand[num];
            _hand.RemoveAt(num-1);
            Console.WriteLine($"{Name} discarded a {card.Display()}");
            return(card);
        }

    }
}