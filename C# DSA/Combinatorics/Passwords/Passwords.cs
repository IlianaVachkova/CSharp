using System;
using System.Numerics;

namespace Passwords
{
    public class Passwords
    {
        public static void Main()
        {
            string pattern = Console.ReadLine();
            int starCount = 0;

            for (int i = 0; i < pattern.Length; i++)
            {
                if (pattern[i] == '*')
                {
                    starCount++;
                }
            }

            BigInteger passwordCount = Power(starCount);
            Console.WriteLine(passwordCount);
        }

        public static BigInteger Power(int count)
        {
            BigInteger result = 1;

            for (int i = 1; i <= count; i++)
            {
                result *= 2;
            }

            return result;
        }
    }
}
