using System;

public class LargestArea
{
    public static int currentMaxPath = 1;
    public static int[,] directions = { { 1, 0 }, { -1, 0 }, { 0, 1 }, { 0, -1 } };

    public static void Main()
    {
        int maxPath = 0;
        int[,] matrix =
        {
            {0, 0, 0, 1, 0, 0, 0},
            {1, 1, 1, 1, 0, 1, 0},
            {0, 0, 1, 0, 0, 0, 0},
            {0, 1, 1, 1, 1, 1, 0},
            {0, 0, 1, 0, 0, 0, 0},
        };

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (matrix[row, col] == 0) // if cell free
                {
                    currentMaxPath = 1;
                    FindLongestArea(matrix, row, col);
                    if (currentMaxPath > maxPath)
                    {
                        maxPath = currentMaxPath;
                        Console.WriteLine("Max path so far: {0}", maxPath);
                        PrintMatrix(matrix);
                    }
                }
            }
        }
    }

    public static void FindLongestArea(int[,] matrix, int row, int col)
    {
        matrix[row, col] = 5; // mark cell as visited

        for (int direction = 0; direction < directions.GetLength(0); direction++)
        {
            int nextRow = row + directions[direction, 0];
            int nextCol = col + directions[direction, 1];
            if (IsInRange(matrix, nextRow, nextCol) && matrix[nextRow, nextCol] == 0)
            {
                currentMaxPath++;
                FindLongestArea(matrix, nextRow, nextCol);
            }
        }
    }

    public static bool IsInRange(int[,] matrix, int row, int col)
    {
        return row < matrix.GetLength(0) && row >= 0 &&
            col < matrix.GetLength(1) && col >= 0;
    }

    public static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0} ", matrix[row, col]);
            }

            Console.WriteLine();
        }

        Console.WriteLine();
    }
}