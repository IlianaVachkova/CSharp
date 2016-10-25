using System;

namespace CardRank
{
    public class Startup
    {
        public static void Main()
        {
            string message = Console.ReadLine();
            Console.WriteLine("{0}:", message);

            var cardsRank = Enum.GetValues(typeof(CardRankType));

            foreach (var cardRank in cardsRank)
            {
                Console.WriteLine("Ordinal value: {0}; Name value: {1}", (int)cardRank, cardRank.ToString());
            }
        }
    }
}
