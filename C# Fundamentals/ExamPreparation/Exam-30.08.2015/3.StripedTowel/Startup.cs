using System;

namespace _3.StripedTowel
{
    public class Startup
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n + n / 2; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((i + j) % 3 == 0)
                    {
                        Console.Write('#');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
