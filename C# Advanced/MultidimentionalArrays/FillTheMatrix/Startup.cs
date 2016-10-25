/*
    Description:
    Write a program that fills and prints a matrix of size (n, n) as shown below.
    
    Input:
    On the first line you will receive the number N
    On the second line you will receive a character (a, b, c, d*) which determines how to fill the matrix
    
    Output:
    Print the matrix
        Numbers on a row must be separated by a single spacebar
        Each row must be on a new line
*/

using System;

public class Startup
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char c = char.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];

        int filler = 1;
        if (c == 'a')
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    matrix[row, col] = filler;
                    filler += 1;
                }
            }
        }
        else if (c == 'b')
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (col%2==0)
                {
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        matrix[row, col] = filler;
                        filler += 1;
                    }
                }
                else
                {
                    for (int row = matrix.GetLength(0)-1; row >=0; row--)
                    {
                        matrix[row, col] = filler;
                        filler += 1;
                    }
                }

                
            }
        }
        else if (c == 'c')
        {
            int fillerDown = 1;
            int fillerUp = n * n;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    matrix[n - i - 1 + j, j] = fillerDown;
                    fillerDown++;

                }
            }
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    matrix[i - j, n - j - 1] = fillerUp;
                    fillerUp--;
                }
            }
        }
        else if (c == 'd')
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                matrix[i, 0] = filler;
                filler+=1;
            }
            int row = n - 1;
            int col = 0;
            int direction = 0;
            for (int j = 1; j < n; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    for (int i = n - j; i > 0; i--)
                    {
                        switch (direction)
                        {
                            case 0:
                                col++;
                                break;
                            case 1:
                                row--;
                                break;
                            case 2:
                                col--;
                                break;
                            case 3:
                                row++;
                                break;
                            default:
                                break;
                        }
                        matrix[row, col] = filler;
                        filler++;
                    }
                    direction++;
                    direction %= 4;
                }
            }
        }

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (col==matrix.GetLength(1)-1)
                {
                    Console.Write(matrix[row, col]);
                }
                else
                {
                    Console.Write(matrix[row, col] + " ");
                }
            }

            Console.WriteLine();
        }
    }
}

