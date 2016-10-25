/*
    Write a program that reads two positive integer numbers N and M and prints 
    how many numbers exist between them such that the reminder of the division 
    by 5 is 0.
*/

using System;

public class Startup
{
    static void Main()
    {
        int beggining = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        int count = 0;

        for (int i = beggining + 1; i < end; i++)
        {
            if (i % 5 == 0)
            {
                count += 1;
            }
        }

        Console.WriteLine(count);
    }
}

