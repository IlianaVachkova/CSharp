/*
    Description:
    Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 
    that has maximal sum of its elements. Print that sum.

    Input:
    On the first line you will receive the numbers N and M separated by a single space
    On the next N lines there will be M numbers separated with spaces - the elements of the matrix
    
    Output:
    Print the maximal sum of 3 x 3 square
*/

using System;

public class Startup
{
    public static void Main()
    {
        string[] dimentions = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int n = int.Parse(dimentions[0]);
        int m = int.Parse(dimentions[1]);
        int[,] matrix = new int[n, m];

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            string[] currentRow = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = int.Parse(currentRow[col]);
            }
        }

        int maxSum = matrix[0, 0] + matrix[0, 1] + matrix[0, 2] +
            matrix[1, 0] + matrix[1, 1] + matrix[1, 2] +
            matrix[2, 0] + matrix[2, 1] + matrix[2, 2];
        int sum = 0;

        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col] +
                    matrix[row + 1, col + 1] + matrix[row + 1, col + 2] + matrix[row + 2, col] + matrix[row + 2, col + 1] +
                    matrix[row + 2, col + 2];

                if (sum > maxSum)
                {
                    maxSum = sum;
                }
            }
        }

        Console.WriteLine(maxSum);
    }
}

