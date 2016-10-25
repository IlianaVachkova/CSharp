using System;

namespace CardCompareTo
{
    public class Startup
    {
        public static void Main()
        {
            Rank rank1;
            Enum.TryParse(Console.ReadLine(), out rank1);
            Suit suit1;
            Enum.TryParse(Console.ReadLine(), out suit1);

            var card1 = new Card(rank1, suit1);

            Rank rank2;
            Enum.TryParse(Console.ReadLine(), out rank2);
            Suit suit2;
            Enum.TryParse(Console.ReadLine(), out suit2);

            var card2 = new Card(rank2, suit2);

            if (card1.CompareTo(card2) == 1)
            {
                Console.WriteLine("Card name: {0}; Card power: {1}", card1.ToString(), card1.CalculatePower());
            }
            else
            {
                Console.WriteLine("Card name: {0}; Card power: {1}", card2.ToString(), card2.CalculatePower());
            }
        }
    }
}
