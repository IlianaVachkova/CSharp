/*
    Write a program that finds the biggest of 5 numbers that are read from the 
    console, using only 5 if statements.
*/

using System;

public class Startup
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double e = double.Parse(Console.ReadLine());

        double biggest = a;
        if ((a == b) && (b == c) && (c == d) && (d == e))
        {
            biggest = a;
        }
        else if ((b >= a) && (b >= c) && (b >= d) && (b >= e))
        {
            biggest = b;
        }
        else if((c >= a) && (c >= b) && (c >= d) && (c >= e))
        {
            biggest = c;
        }
        else if((d >= a) && (d >= b) && (d >= c) && (d >= e))
        {
            biggest = d;
        }
        else if((e >= a) && (e >= b) && (e >= c) && (e >= d))
        {
            biggest = e;
        }

        Console.WriteLine(biggest);
    }
}