using System;

namespace CardSuit
{
    public class Startup
    {
        public static void Main()
        {
            string message = Console.ReadLine();
            Console.WriteLine("{0}:", message);

            var cardsType = Enum.GetValues(typeof(CardType));

            foreach (var cardType in cardsType)
            {
                Console.WriteLine("Ordinal value: {0}; Name value: {1}", (int)cardType, cardType.ToString());
            }
        }
    }
}
