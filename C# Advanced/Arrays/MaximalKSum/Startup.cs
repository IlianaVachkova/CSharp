/*
    Write a program that reads two integer numbers N and K and an array of N elements from the 
    console. Find the maximal sum of K elements in the array.
*/

using System;

public class Startup
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int numOfElements = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(array);
        int sum = 0;
        for (int i = array.Length-1; i >array.Length-1-numOfElements; i--)
        {
            sum += array[i];
        }

        Console.WriteLine(sum);
    }
}

