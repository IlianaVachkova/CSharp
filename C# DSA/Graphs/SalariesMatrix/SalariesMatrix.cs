using System;
using System.Collections.Generic;

class SalariesMatrix
{
    static int sum = 0;

    static void Main()
    {
#if DEBUG
        Console.SetIn(new System.IO.StreamReader("..//..//input.txt"));
#endif

        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];


        for (int row = 0; row < n; row++)
        {
            string line = Console.ReadLine();

            for (int col = 0; col < line.Length; col++)
            {
                if (line[col] == 'Y')
                {
                    matrix[row, col] = 1;
                }
            }
        }

        Console.WriteLine(sum);
    }

    static int FindSalary(int node)
    {
        return 0;
    }
}