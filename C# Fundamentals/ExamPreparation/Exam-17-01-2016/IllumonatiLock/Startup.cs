using System;

namespace IllumonatiLock
{
    public class Startup
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('.', n) + new string('#', n) + new string('.', n));

            for (int i = 1; i <= n / 2; i++)
            {
                Console.WriteLine(new string('.', n - 2 * i) + new string('#', 2) + new string('.', 2 * i - 2) + '#' + new string('.', n - 2)
                    + '#' + new string('.', 2 * i - 2) + new string('#', 2) + new string('.', n - 2 * i));
            }

            for (int i = n / 2; i >= 1; i--)
            {
                Console.WriteLine(new string('.', n - 2 * i) + new string('#', 2) + new string('.', 2 * i - 2) + '#' + new string('.', n - 2)
                    + '#' + new string('.', 2 * i - 2) + new string('#', 2) + new string('.', n - 2 * i));
            }

            Console.WriteLine(new string('.', n) + new string('#', n) + new string('.', n));
        }
    }
}
