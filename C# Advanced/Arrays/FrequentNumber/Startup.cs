/*
    Write a program that finds the most frequent number in an array.
*/

using System;

public class Startup
{
    public static void Main()
    {
        //int[] arr = new int[] { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }


        int length = arr.Length;
        bool[] found = new bool[length];
        int mostFreq = 0;
        int number = Int32.MinValue;

        for (int i = 0; i < length - 1; i++)
        {
            if (!found[i])
            {
                int freq = 1;
                for (int j = i + 1; j < length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        freq++;
                        found[j] = true;
                    }
                }
                if (freq > mostFreq)
                {
                    mostFreq = freq;
                    number = arr[i];
                }
            }
        }

        Console.WriteLine("{0} ({1} times)", number, mostFreq);
    }
}