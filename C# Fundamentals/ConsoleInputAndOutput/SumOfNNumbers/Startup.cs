/*
    Write a program that reads an integer number N from the console and 
    prints all the numbers in the interval [1, n], each on a single line.
*/

using System;

public class Startup
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double sum = 0.0;
        for (int i = 0; i < n; i++)
        {
            double number = double.Parse(Console.ReadLine());
            sum += number;
        }
        Console.WriteLine(sum);
    }
}

