using System;

namespace _3.Summertime
{
    public class Startup
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string(' ', (n - 1) / 2) + new string('*', (n + 1)) + new string(' ', (n - 1) / 2));

            for (int i = 0; i < (n / 2 + 1); i++)
            {
                Console.WriteLine(new string(' ', (n - 1) / 2) + '*' + new string(' ', (n - 1)) + '*'
                    + new string(' ', (n - 1) / 2));
            }

            for (int i = 0; i < (n / 2 - 1); i++)
            {
                Console.WriteLine(new string(' ', (n - 1) / 2 - i - 1) + '*' + new string(' ', (n + 1) + 2 * i) + '*'
                    + new string(' ', (n - 1) / 2 - i - 1));
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine('*' + new string('.', 2 * n - 2) + '*');
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine('*' + new string('@', 2 * n - 2) + '*');
            }

            Console.WriteLine(new string('*', 2 * n));
        }
    }
}
