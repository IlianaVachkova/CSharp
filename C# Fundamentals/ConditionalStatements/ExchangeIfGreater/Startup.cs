/*
    Write a program that reads two double values from the console 
    A and B, stores them in variables and exchanges their values 
    if the first one is greater than the second one. Use an if-statement. 
    As a result print the values of the variables A and B, separated by a space.
*/

using System;

public class Startup
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        if (a > b)
        {
            Console.WriteLine("{0} {1}", b, a);
        }
        else
        {
            Console.WriteLine("{0} {1}", a, b);
        }
    }
}

