using System;

namespace CardPower
{
    public class Startup
    {
        public static void Main()
        {
            Rank rank;
            Enum.TryParse(Console.ReadLine(), out rank);
            Suit suit;
            Enum.TryParse(Console.ReadLine(), out suit);

            var card = new Card(rank, suit);

            Console.WriteLine("Card name: {0}; Card power: {1}", card.ToString(), card.CalculatePower());
        }
    }
}
