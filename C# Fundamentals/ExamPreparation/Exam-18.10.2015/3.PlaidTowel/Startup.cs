using System;

namespace _3.PlaidTowel
{
    public class Startup
    {
        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            char backgroundSymbol = char.Parse(Console.ReadLine());
            char rhombusSymbol = char.Parse(Console.ReadLine());

            char[,] matrix = new char[size * 4 + 1, size * 4 + 1];

            for (int i = 0; i < size * 4 + 1; i++)
            {
                for (int j = 0; j < size * 4 + 1; j++)
                {
                    if ((i + j) == size || (i + j) == size * 3 || (i + j) == size * 5 || (i + j) == size * 7 || (i + j) == (size * 3 + 2 * i)
                        || (i + j) == (size + 2 * j) || (i + j) == (size + 2 * i) || (i + j) == (size * 3 + 2 * j))
                    {
                        matrix[i, j] = rhombusSymbol;
                    }
                    else
                    {
                        matrix[i, j] = backgroundSymbol;
                    }
                }
            }

            for (int i = 0; i < size * 4 + 1; i++)
            {
                for (int j = 0; j < size * 4 + 1; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
