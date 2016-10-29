using System;

namespace _3.Headphones
{
    public class Startup
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('-', n / 2) + new string('*', n + 2) + new string('-', n / 2));
            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine(new string('-', n / 2) + '*' + new string('-', n) + '*' + new string('-', n / 2));
            }

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine(new string('-', n / 2 - i) + new string('*', 1 + 2 * i) + new string('-', n - 2 * i)
                    + new string('*', 1 + 2 * i) + new string('-', n / 2 - i));
            }

            Console.WriteLine(new string('*', n) + '-' + new string('*', n));

            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Console.WriteLine(new string('-', n / 2 - i) + new string('*', 1 + 2 * i) + new string('-', n - 2 * i)
                    + new string('*', 1 + 2 * i) + new string('-', n / 2 - i));
            }
        }
    }
}
