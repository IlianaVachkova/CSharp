using System;

public class AllPassableAreas
{
    public static void Main()
    {
        // 0 -> Passable cell, 1 -> Non-passable cell
        int[,] matrix = 
        { 
            {0, 0, 0, 1, 0, 0, 1},
            {1, 1, 1, 1, 0, 1, 0},
            {0, 0, 1, 0, 1, 0, 0},
            {0, 1, 1, 1, 1, 1, 0},
            {0, 0, 1, 0, 0, 0, 0},
        };
        int value = 3;

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (matrix[row, col] == 0)
                {
                    FindAllPassableAreas(matrix, row, col, value);
                    value++;
                    
                }
            }
        }

        // All the different passable areas are filled with numbers starting from 3
        PrintMatrix(matrix);
    }

    public static void FindAllPassableAreas(int[,] matrix, int row, int col, int value)
    {
        matrix[row, col] = value;

        int[,] directions = { { 1, 0 }, { 0, 1 }, { -1, 0 }, { 0, -1 } };

        for (int direction = 0; direction < directions.GetLength(0); direction++)
        {
            int newRow = row + directions[direction, 0];
            int newCol = col + directions[direction, 1];

            if (IsInRange(matrix, newRow, newCol) && matrix[newRow, newCol] == 0)
            {
                FindAllPassableAreas(matrix, newRow, newCol, value);
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