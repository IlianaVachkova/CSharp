using System;

public class AllPathsBetweenTwoCells
{
    public static int pathsCount = 0;

    public static void Main()
    {
        // Task 7 - comment this when testing Task 8
        char[,] matrix = 
        {
            {'-', '-', '-', '*', '-', '-', '-'},
            {'*', '*', '-', '*', '-', '*', '-'},
            {'-', '-', '-', '-', '-', '-', '-'},
            {'-', '*', '*', '*', '*', '*', '-'},
            {'-', '-', 'X', '-', '-', '-', '-'},
        };
        FindAllPaths(matrix, 0, 4);

        // Uncomment for Task 8
        //var newMatrix = new char[100, 100];
        //FillMatrixWithEmptyCells(newMatrix);
        //FindAllPaths(newMatrix, 0, 0);
    }

    public static void FindAllPaths(char[,] matrix, int row, int col)
    {
        if (!IsInBoundries(matrix, row, col))
        {
            return;
        }

        if (matrix[row, col] == 'X')
        {
            pathsCount++;
            Console.WriteLine("Paths count so far: {0}", pathsCount);
            PrintMatrix(matrix);
            //Environment.Exit(0); // Uncomment for Task 8 -> we stop when path found
            return;
        }

        if (matrix[row, col] != '-')
        {
            return;
        }

        matrix[row, col] = 'P'; // mark cell as visited
        FindAllPaths(matrix, row, col + 1);
        FindAllPaths(matrix, row, col - 1);
        FindAllPaths(matrix, row + 1, col);
        FindAllPaths(matrix, row - 1, col);
        matrix[row, col] = '-'; // mark cell as free on the way back
    }

    public static bool IsInBoundries(char[,] matrix, int row, int col)
    {
        return row >= 0 && row < matrix.GetLength(0) &&
            col >= 0 && col < matrix.GetLength(1);
    }

    public static void PrintMatrix(char[,] matrix)
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

    public static void FillMatrixWithEmptyCells(char[,] matrixToFill)
    {
        for (int row = 0; row < matrixToFill.GetLength(0); row++)
        {
            for (int col = 0; col < matrixToFill.GetLength(1) - 1; col++)
            {
                matrixToFill[row, col] = '-';
            }
        }

        // we  put exit sign 'X' on the last right down corner of the matrix
        matrixToFill[matrixToFill.GetLength(0) - 1, matrixToFill.GetLength(0) - 2] = 'X';
    }
}