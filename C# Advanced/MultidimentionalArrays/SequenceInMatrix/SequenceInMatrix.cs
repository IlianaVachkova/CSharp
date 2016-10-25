/*
    Description:
    We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of 
    several neighbour elements located on the same line, column or diagonal. Write a program that 
    finds the longest sequence of equal strings in the matrix and prints its length.
    
    Input:
    On the first line you will receive the numbers N and M separated by a single space
    On the next N lines there will be M strings separated with spaces - the strings in the matrix
    
    Output:
    Print the length of the longest sequence of equal equal strings in the matrix
*/

using System;

public class Startup
{
    public static void Main()
    {
        string[] dimentions = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int n = int.Parse(dimentions[0]);
        int m = int.Parse(dimentions[1]);
        string[,] matrix = new string[n, m];

        int longestSequence = 1;
        string currentCell = string.Empty;
        int currentSequence = 1;
        int diagonal = Math.Min(n, m);

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            string[] currentRow = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = currentRow[col];
            }
        }

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            currentCell = matrix[row, 0];
            for (int col = 1; col < matrix.GetLength(1); col++)
            {
                if (currentCell == matrix[row, col])
                {
                    currentSequence++;
                }
                else
                {
                    if (currentSequence > longestSequence)
                    {
                        longestSequence = currentSequence;
                    }

                    currentSequence = 1;
                    currentCell = matrix[row, col];
                }
            }

            if (currentSequence > longestSequence)
            {
                longestSequence = currentSequence;
            }

            currentSequence = 1;
        }

        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            currentCell = matrix[0, col];
            for (int row = 1; row < matrix.GetLength(0); row++)
            {
                if (currentCell == matrix[row, col])
                {
                    currentSequence++;
                }
                else
                {
                    if (currentSequence > longestSequence)
                    {
                        longestSequence = currentSequence;
                    }

                    currentSequence = 1;
                    currentCell = matrix[row, col];
                }
            }

            if (currentSequence > longestSequence)
            {
                longestSequence = currentSequence;
            }

            currentSequence = 1;
        }

        for (int d = 0; d < diagonal; d++)
        {
            for (int row = 0, col = d; row < matrix.GetLength(0) - 1 && col < matrix.GetLength(1) - 1; row++, col++)
            {
                if ((matrix[row, col] == matrix[row + 1, col + 1]))
                {
                    currentSequence++;
                }
                else
                {
                    if (currentSequence > longestSequence)
                    {
                        longestSequence = currentSequence;
                    }

                    currentSequence = 1;
                }
            }

            if (currentSequence > longestSequence)
            {
                longestSequence = currentSequence;
            }

            currentSequence = 1;
        }

        for (int d = 1; d < diagonal - 1; d++)
        {
            for (int row = d, col = 0; row < matrix.GetLength(0) - 1 && col < matrix.GetLength(1) - 1; row++, col++)
            {
                if ((matrix[row, col] == matrix[row + 1, col + 1]))
                {
                    currentSequence++;
                }
                else
                {
                    if (currentSequence > longestSequence)
                    {
                        longestSequence = currentSequence;
                    }

                    currentSequence = 1;
                }
            }

            if (currentSequence > longestSequence)
            {
                longestSequence = currentSequence;
            }

            currentSequence = 1;
        }

        for (int d = 0; d < diagonal; d++)
        {
            for (int row = 0, col = matrix.GetLength(1) - d - 1; row < matrix.GetLength(0) - 1 && col > 0; row++, col--)
            {
                if ((matrix[row, col] == matrix[row + 1, col - 1]))
                {
                    currentSequence++;
                }
                else
                {
                    if (currentSequence > longestSequence)
                    {
                        longestSequence = currentSequence;
                    }

                    currentSequence = 1;
                }
            }

            if (currentSequence > longestSequence)
            {
                longestSequence = currentSequence;
            }

            currentSequence = 1;
        }

        for (int d = 1; d < diagonal - 1; d++)
        {
            for (int row = d, col = matrix.GetLength(1) - 1; row < matrix.GetLength(0) - 1 && col > 0; row++, col--)
            {
                if ((matrix[row, col] == matrix[row + 1, col - 1]))
                {
                    currentSequence++;
                }
                else
                {
                    if (currentSequence > longestSequence)
                    {
                        longestSequence = currentSequence;
                    }

                    currentSequence = 1;
                }
            }

            if (currentSequence > longestSequence)
            {
                longestSequence = currentSequence;
            }

            currentSequence = 1;
        }

        Console.WriteLine(longestSequence);
    }
}