using System;

namespace CustomEnumAttribute
{
    public class Startup
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Type type = null;
            if (input == "Rank")
            {
                type = typeof(Rank);
            }
            else if (input == "Suit")
            {
                type = typeof(Suit);
            }

            var customAttributes = type.GetCustomAttributes(false);
            foreach (TypeAttribute attribute in customAttributes)
            {
                Console.WriteLine("Type = {0}, Description = {1}", attribute.Type, attribute.Description);
            }
        }
    }
}
