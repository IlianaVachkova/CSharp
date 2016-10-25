/*
    Write an expression that calculates rectangle’s area and perimeter by given width and height. 
    The width and height should be read from the console.
*/

using System;

public class Startup
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double heigth = double.Parse(Console.ReadLine());

        double area = width * heigth;
        double perimeter = 2 * width + 2 * heigth;

        Console.WriteLine("{0:0.00} {1:0.00}", area, perimeter);
    }
}
