using System;

namespace _3.KingOfThieves
{
    public class Startup
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char type = char.Parse(Console.ReadLine());

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine(new string('-', n / 2 - i) + new string(type, n % 2 + 2 * i) + new string('-', n / 2 - i));
            }

            Console.WriteLine(new string(type, n));

            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Console.WriteLine(new string('-', n / 2 - i) + new string(type, n % 2 + 2 * i) + new string('-', n / 2 - i));
            }
        }
    }
}
