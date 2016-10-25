/*
    Description:
    Write program that calculates the surface of a triangle by given two sides and an angle between them.
    
    Input:
    On the first line you will receive the length of the first side of the triangle
    On the second line you will receive the length of the second side of the triangle
    On the third line you will receive the angle between the given sides
        Angle is given in degrees
    
    Output:
    Print the surface of the rectangle with two digits of precision
*/

using System;

public class Startup
{
    public static void Main()
    {
        double side1 = double.Parse(Console.ReadLine());
        double side2 = double.Parse(Console.ReadLine());
        double angle = double.Parse(Console.ReadLine());

        Console.WriteLine("{0:0.00}", TwoSidesAngle(side1, side2, angle));
    }

    public static double TwoSidesAngle(double firstSide, double secondSide, double angle)
    {
        double angleInRad = angle * Math.PI / 180;
        double surface = Convert.ToDouble((firstSide * secondSide * Math.Sin(angleInRad)) / 2);

        return surface;
    }
}

