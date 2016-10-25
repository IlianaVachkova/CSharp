/*
    Write a program that finds the length of the maximal sequence of equal elements in an array of N integers.
*/

using System;

public class Startup
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int currentLen = 1;
        int maxLen = 1;
        int element = array[0];

        for (int i = 1; i < n; i++)
        {
            if (element==array[i])
            {
                currentLen += 1;

                if (currentLen > maxLen)
                {
                    maxLen = currentLen;
                }
            }
            else
            {
                currentLen = 1;
                element = array[i];
            }

        }

        Console.WriteLine(maxLen);
    }
}

