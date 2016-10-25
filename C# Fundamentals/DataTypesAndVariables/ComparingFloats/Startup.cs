/*
    Write a program that safely compares two floating-point numbers (double) with precision eps = 0.000001.

    Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of 
    the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each 
    other than a fixed constant eps.
*/

using System;

public class Startup
{
    static void Main()
    {
        double firstNumber = Double.Parse(Console.ReadLine());
        double secondNumber = Double.Parse(Console.ReadLine());

        double eps = 0.000001;

        if (Math.Abs(firstNumber - secondNumber) < eps)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}
