/*
    Description:
    Write a method that returns the index of the first element in array that is larger than its 
    neighbours, or -1, if there is no such element.
    
    Input:
    On the first line you will receive the number N - the size of the array
    On the second line you will receive N numbers sepated by spaces - the array
    
    Output:
    Print the index of the first element that is larger than its neighbours or -1 if none are
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

        Console.WriteLine(IndexFirstLargerThanNeighbours(array));
    }

    public static int IndexFirstLargerThanNeighbours(params int[] array)
    {
        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i] > array[i - 1] && array[i] > array[i + 1])
            {
                return i;
            }
        }

        return -1;
    }
}

