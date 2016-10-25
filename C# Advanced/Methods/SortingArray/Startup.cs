/*
    Description:
    Write a method that returns the maximal element in a portion of array of integers 
    starting at given index. Using it write another method that sorts an array in 
    ascending / descending order. Write a program that sorts a given array.
    
    Input:
    On the first line you will receive the number N - the size of the array
    On the second line you will receive N numbers separated by spaces - the array
    
    Output:
    Print the sorted array
        Elements must be separated by spaces
*/

using System;

public class Startup
{
    public static void Main()
    {
        int arrSize = int.Parse(Console.ReadLine());
        string[] arrAsStr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] array = new int[arrAsStr.Length];

        for (int i = 0; i < arrAsStr.Length; i++)
        {
            array[i] = int.Parse(arrAsStr[i]);
        }

        DecendingSortOfArray(array);
        Array.Reverse(array);
        Console.WriteLine(String.Join(" ", array));
    }

    public static int MaxIndex(int start, int[] array)
    {
        int maxIndex = -1;
        int max = int.MinValue;

        for (int i = start; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                maxIndex = i;
            }
        }

        return maxIndex;
    }

    public static void Swap(ref int first, ref int second)
    {
        int swap = first;
        first = second;
        second = swap;
    }

    public static void DecendingSortOfArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int maxIndex = MaxIndex(i, array);
            Swap(ref array[maxIndex], ref array[i]);
        }
    }
}

