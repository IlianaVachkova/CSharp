using System;

namespace _3.Boat_newString
{
    public class Startup
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine(new string('.', n - 1 - 2 * i) + new string('*', 1 + 2 * i) + new string('.', n));
            }

            Console.WriteLine(new string('*', n) + new string('.', n));

            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Console.WriteLine(new string('.', n - 1 - 2 * i) + new string('*', 1 + 2 * i) + new string('.', n));
            }

            for (int i = 0; i < (n - 1) / 2; i++)
            {
                Console.WriteLine(new string('.', i) + new string('*', 2 * n - 2 * i) + new string('.', i));
            }
        }
    }
}
