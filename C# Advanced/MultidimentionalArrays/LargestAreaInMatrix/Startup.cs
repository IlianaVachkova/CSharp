/*
    Description:
    Write a program that finds the largest area of equal neighbour elements in a rectangular matrix and prints its size.
    
    Input:
    On the first line you will receive the numbers N and M separated by a single space
    On the next N lines there will be M numbers separated with spaces - the elements of the matrix
    
    Output:
    Print the size of the largest area of equal neighbour elements
*/

using System;
using System.Collections.Generic;

public class LargestAreaInMatrix
{
    public static string[] dimentions = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

    public static int rowLenght = int.Parse(dimentions[0]);
    public static int colLenght = int.Parse(dimentions[1]);
    public static int[,] matrix = new int[rowLenght, colLenght];

    static bool[,] visited = new bool[rowLenght, colLenght];

    public static void Main()
    {
        int maxLen = -1;

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            string[] currentRow = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = int.Parse(currentRow[col]);
            }
        }

        for (int row = 0; row < rowLenght; row++)
        {
            for (int col = 0; col < colLenght; col++)
            {
                int currentLen = DFS(matrix, row, col);

                if (currentLen > maxLen)
                {
                    maxLen = currentLen;
                }
            }
        }

        Console.WriteLine(maxLen);
    }

    public static bool InRange(int[,] matrix, int row, int col)
    {
        bool result;
        result = (row >= 0) && (col >= 0) &&
            (row < matrix.GetLength(0)) && (col < matrix.GetLength(1));

        return result;
    }

    public static int DFS(int[,] matrix, int row, int col)
    {
        Stack<int> path = new Stack<int>();
        int[] rowDirections = { 1, -1, 0, 0 };
        int[] colDirections = { 0, 0, -1, 1 };
        int count = 1;
        path.Push(row);
        path.Push(col);

        int nextRow = row;
        int nextCol = col;
        visited[nextRow, nextCol] = true;

        while (path.Count > 0)
        {
            //int stackSize = path.Count;
            int inCount = 0;
            for (int i = 0; i < 4; i++)
            {
                if ((InRange(matrix, nextRow + rowDirections[i], nextCol + colDirections[i]))
                    && (!visited[nextRow + rowDirections[i], nextCol + colDirections[i]]))
                {
                    if ((matrix[nextRow, nextCol] == matrix[nextRow + rowDirections[i], nextCol + colDirections[i]]))
                    {
                        inCount++;
                        count++;
                        nextRow = nextRow + rowDirections[i];
                        nextCol = nextCol + colDirections[i];
                        visited[nextRow, nextCol] = true;
                        path.Push(nextRow);
                        path.Push(nextCol);
                        break;
                    }
                }
            }

            if (inCount == 0) // check if we found equal element
            {
                nextCol = path.Pop();
                nextRow = path.Pop();
            }
        }

        return count;
    }
}

