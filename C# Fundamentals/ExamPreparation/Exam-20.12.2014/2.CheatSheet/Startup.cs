using System;

namespace _2.CheatSheet
{
    public class Startup
    {
        public static void Main()
        {
            long rows = long.Parse(Console.ReadLine());
            long cols = long.Parse(Console.ReadLine());
            long rowStartIndex = long.Parse(Console.ReadLine());
            long colStartIndex = long.Parse(Console.ReadLine());

            long[,] matrix = new long[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = rowStartIndex * colStartIndex;
                    Console.Write(matrix[i, j] + " ");
                    colStartIndex += 1;
                }

                rowStartIndex += 1;
                colStartIndex -= cols;

                Console.WriteLine();
            }
        }
    }
}
