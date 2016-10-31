using System;

namespace _3.Dumbbel
{
    public class Startup
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('.', n / 2) + new string('&', n / 2 + 1) + new string('.', n)
                + new string('&', n / 2 + 1) + new string('.', n / 2));

            for (int i = 0; i < n / 2 - 1; i++)
            {
                Console.WriteLine(new string('.', n / 2 - 1 - i) + '&' + new string('*', n / 2 + i) + '&' + new string('.', n) + '&'
                    + new string('*', n / 2 + i) + '&' + new string('.', n / 2 - 1 - i));
            }

            Console.WriteLine('&' + new string('*', n - 2) + '&' + new string('=', n) + '&' + new string('*', n - 2) + '&');

            for (int i = n / 2 - 2; i >= 0; i--)
            {
                Console.WriteLine(new string('.', n / 2 - 1 - i) + '&' + new string('*', n / 2 + i) + '&' + new string('.', n) + '&'
                    + new string('*', n / 2 + i) + '&' + new string('.', n / 2 - 1 - i));
            }

            Console.WriteLine(new string('.', n / 2) + new string('&', n / 2 + 1) + new string('.', n)
                + new string('&', n / 2 + 1) + new string('.', n / 2));
        }
    }
}
