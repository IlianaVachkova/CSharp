/*
    Description:
    Write a method that counts how many times given number appears in a given array. 
    Write a test program to check if the method is working correctly.
    
    Input:
    On the first line you will receive a number N - the size of the array
    On the second line you will receive N numbers separated by spaces - the numbers in the array
    On the third line you will receive a number X
    
    Output:
    Print how many times the number X appears in the array
*/

using System;

public class Startup
{
    public static void Main()
    {
        int arraySize = int.Parse(Console.ReadLine());
        int[] array = new int[arraySize];
        string[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(numbers[i]);
        }

        int numToCount = int.Parse(Console.ReadLine());

        Console.WriteLine(CountNumber(numToCount, array));
    }

    public static int CountNumber(int number, params int[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (number == array[i])
            {
                count++;
            }
        }

        return count;
    }
}

