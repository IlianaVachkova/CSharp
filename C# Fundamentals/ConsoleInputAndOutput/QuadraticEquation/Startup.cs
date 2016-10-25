/*
    Write a program that reads the coefficients a, b and c of a quadratic 
    equation ax2 + bx + c = 0 and solves it (prints its real roots).
*/

using System;

public class Startup
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double descriminant = (b * b - 4 * a * c);
        double x1;
        double x2;
        if (descriminant > 0)
        {
            x1 = (-b + Math.Sqrt(descriminant)) / (2 * a);
            x2 = (-b - Math.Sqrt(descriminant)) / (2 * a);
            Console.WriteLine("{0:0.00}", x2);
            Console.WriteLine("{0:0.00}", x1);
        }
        if (descriminant < 0)
        {
            Console.WriteLine("no real roots");
        }
        if (descriminant == 0)
        {
            x1 = x2 = -b / (2 * a);
            Console.WriteLine("{0:0.00}", x1);
        }
    }
}

