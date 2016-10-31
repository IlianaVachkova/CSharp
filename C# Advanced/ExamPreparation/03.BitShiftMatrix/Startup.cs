using System;
using System.Linq;
using System.Numerics;

public class Startup
{
    public static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());
        int numOfMoves = int.Parse(Console.ReadLine());
        int[] codes = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();

        BigInteger[,] matrix = new BigInteger[rows, cols];

        int baseFiller = 0;
        for (int col = 0; col < cols; col++)
        {
            baseFiller = col;
            for (int row = rows - 1; row >= 0; row--)
            {
                matrix[row, col] = Power(2, baseFiller);
                baseFiller++;
            }
        }

        int currentRow = rows - 1;
        int currentCol = 0;
        BigInteger sum = 1;
        matrix[currentRow, currentCol] = -1;
        int code = 0;
        int coef = Math.Max(rows, cols);
        int rowToReach = 0;
        int colToReach = 0;

        for (int i = 0; i < codes.Length; i++)
        {
            code = codes[i];
            rowToReach = code / coef;
            colToReach = code % coef;

            while (currentCol != colToReach)
            {
                if (matrix[currentRow, currentCol] != -1)
                {
                    sum += matrix[currentRow, currentCol];
                    matrix[currentRow, currentCol] = -1;
                }

                if (currentCol < colToReach)
                {
                    currentCol++;
                }
                else if (currentCol > colToReach)
                {
                    currentCol--;
                }
            }

            while (currentRow != rowToReach)
            {
                if (matrix[currentRow, currentCol] != -1)
                {
                    sum += matrix[currentRow, currentCol];
                    matrix[currentRow, currentCol] = -1;
                }

                if (currentRow < rowToReach)
                {
                    currentRow++;
                }
                else if (currentRow > rowToReach)
                {
                    currentRow--;
                }
            }

            if (matrix[currentRow, currentCol] != -1)
            {
                sum += matrix[currentRow, currentCol];
                matrix[currentRow, currentCol] = -1;
            }


        }

        Console.WriteLine(sum);
    }

    static BigInteger Power(int num, int step)
    {
        BigInteger result = 1;

        for (int i = 1; i <= step; i++)
        {
            result *= num;
        }

        return result;
    }
}
