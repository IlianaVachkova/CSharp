using System;

namespace DeckOfCards
{
    public class Startup
    {
        public static void Main()
        {
            Console.ReadLine();

            var cardsRank = Enum.GetValues(typeof(Rank));
            var cardsSuit = Enum.GetValues(typeof(Suit));

            foreach (var cardSuit in cardsSuit)
            {
                foreach (var cardRank in cardsRank)
                {
                    Console.WriteLine("{0} of {1}", cardRank.ToString(), cardSuit.ToString());
                }
            }
        }
    }
}
