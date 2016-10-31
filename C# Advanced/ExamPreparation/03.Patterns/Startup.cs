using System;
using System.Linq;
using System.Numerics;

public class Startup
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            int[] numsInRow = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = numsInRow[col];
            }
        }

        BigInteger maxSum = BigInteger.MinusOne;
        BigInteger currentSum = 0;
        BigInteger diagonalSum = 0;
        int currentCell = 0;
        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 4; col++)
            {

                bool isValidPattern = true;
                currentCell = matrix[row, col];
                currentSum = currentCell;

                for (int patCol = col + 1; patCol < col + 3; patCol++)
                {
                    if ((currentCell + 1) == matrix[row, patCol] && isValidPattern)
                    {
                        currentSum += matrix[row, patCol];
                        currentCell = matrix[row, patCol];
                    }
                    else
                    {
                        isValidPattern = false;
                        break;
                    }
                }

                if ((currentCell + 1) == matrix[row + 1, col + 2] && isValidPattern)
                {
                    currentSum += matrix[row + 1, col + 2];
                    currentCell = matrix[row + 1, col + 2];
                }
                else
                {
                    isValidPattern = false;
                }

                for (int patCol = col + 2; patCol < col + 5; patCol++)
                {
                    if ((currentCell + 1) == matrix[row + 2, patCol] && isValidPattern)
                    {
                        currentSum += matrix[row + 2, patCol];
                        currentCell = matrix[row + 2, patCol];
                    }
                    else
                    {
                        isValidPattern = false;
                        break;
                    }
                }

                if (isValidPattern && currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
            }
        }

        for (int diagonal = 0; diagonal < n; diagonal++)
        {
            diagonalSum += matrix[diagonal, diagonal];
        }

        if (maxSum != BigInteger.MinusOne)
        {
            Console.WriteLine("YES {0}", maxSum);
        }
        else
        {
            Console.WriteLine("NO {0}", diagonalSum);
        }
    }
}

