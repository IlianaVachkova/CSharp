/*
    Write a program that reads two integer arrays of size N from the console and compares them element by element.
*/

using System;

public class Startup
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] firstArr = new int[n];
        int[] secondArr = new int[n];

        for (int i = 0; i < n; i++)
        {
            firstArr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            secondArr[i] = int.Parse(Console.ReadLine());
        }

        bool notEqual = false;
        for (int i = 0; i < n; i++)
        {
            if (firstArr[i]!=secondArr[i])
            {
                Console.WriteLine("Not equal");
                notEqual = true;
                break;
            }
        }

        if (!notEqual)
        {
            Console.WriteLine("Equal");
        }
    }
}

