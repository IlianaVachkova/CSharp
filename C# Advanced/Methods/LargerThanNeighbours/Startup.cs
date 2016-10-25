/*
    Description:
    Write a method that checks if the element at given position in given array of integers 
    is larger than its two neighbours (when such exist). Write program that reads an array 
    of numbers and prints how many of them are larger than their neighbours.
    
    Input:
    On the first line you will receive the number N - the size of the array
    On the second line you will receive N numbers separated by spaces - the array
    
    Output:
    Print how many numbers in the array are larger than their neighbours
*/

using System;

public class Startup
{
    public static void Main()
    {
        int arraySize = int.Parse(Console.ReadLine());
        string[] arrayAsStr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] array = new int[arraySize];

        for (int i = 0; i < arraySize; i++)
        {
            array[i] = int.Parse(arrayAsStr[i]);
        }

        Console.WriteLine(CountSmallerNeighbours(array));
    }

    public static int CountSmallerNeighbours(params int[] array)
    {
        int count = 0;

        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i] > array[i - 1] && array[i] > array[i + 1])
            {
                count++;
            }
        }

        return count;
    }
}

