using System;
using DeckOCards.Models;

namespace DeckOCards
{
    class Program
    {
        static void Main(string[] args)
        {
        //    Card c1 = new Card("Diamonds", "3", 3);
        //    Console.WriteLine(c1.Display());
        Deck d1 = new Deck();
        d1.Shuffle();
        // d1.Display();
        // d1.Draw();
        // d1.Display();
        // d1.Deal(5);
        Player p1 = new Player(d1, "Kyle");
        p1.DrawCards(5);
        p1.Display();
        p1.Discard(3);
        p1.Display();
        }
    }
}
