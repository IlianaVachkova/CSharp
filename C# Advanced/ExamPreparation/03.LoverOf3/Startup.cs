using System;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        int[] dimentions = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();

        int rows = dimentions[0];
        int cols = dimentions[1];
        int numOfDirsAndMoves = int.Parse(Console.ReadLine());
        int[,] matrix = new int[rows, cols];
        string direction = string.Empty;
        int moves = 0;

        int baseFiller = 0;
        for (int col = 0; col < cols; col++)
        {
            baseFiller = col;
            for (int row = rows - 1; row >= 0; row--)
            {
                matrix[row, col] = 3 * baseFiller;
                baseFiller++;
            }
        }

        int currentRow = rows - 1;
        int currentCol = 0;
        long sum = 0;
        for (int i = 0; i < numOfDirsAndMoves; i++)
        {
            string[] dirsAndMoves = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            direction = dirsAndMoves[0];
            moves = int.Parse(dirsAndMoves[1]);

            for (int step = 0; step < moves; step++)
            {
                if (matrix[currentRow, currentCol] != -1)
                {
                    sum += matrix[currentRow, currentCol];
                    matrix[currentRow, currentCol] = -1;
                }

                if ((direction == "RU" || direction == "UR") && step != moves - 1 && (currentCol < cols - 1) && currentRow > 0)
                {
                    currentCol++;
                    currentRow--;
                }
                else if ((direction == "LU" || direction == "UL") && step != moves - 1 && (currentCol > 0) && currentRow > 0)
                {
                    currentCol--;
                    currentRow--;
                }
                else if ((direction == "DL" || direction == "LD") && step != moves - 1 && (currentCol > 0) && currentRow < rows - 1)
                {
                    currentCol--;
                    currentRow++;
                }
                else if ((direction == "RD" || direction == "DR") && step != moves - 1 && (currentCol < cols - 1) && currentRow < rows - 1)
                {
                    currentCol++;
                    currentRow++;
                }
            }
        }

        Console.WriteLine(sum);
    }
}

