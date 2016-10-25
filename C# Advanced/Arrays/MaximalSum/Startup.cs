/*
    Write a program that finds the maximal sum of consecutive elements in a given array of N numbers.
*/

using System;

public class Startup
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int sum = int.Parse(Console.ReadLine());
        int maxSum = sum;
        int number = 0;

        for (int i = 1; i < n; i++)
        {
            number = int.Parse(Console.ReadLine());

            sum += number;
            if (sum < number)
            {
                sum = number;
            }
            if (maxSum < sum)
            {
                maxSum = sum;
            }
        }

        Console.WriteLine(maxSum);
    }
}

