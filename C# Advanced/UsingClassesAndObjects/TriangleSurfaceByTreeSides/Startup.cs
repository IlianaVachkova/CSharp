/*
    Description:
    Write program that calculates the surface of a triangle by given its three sides.
    
    Input:
    On the first line you will receive the length of the first side of the triangle
    On the second line you will receive the length of the second side of the triangle
    On the third line you will receive the length of the third side of the triangle
    
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
        double side3 = double.Parse(Console.ReadLine());

        Console.WriteLine("{0:0.00}", ThreeSidesSurface(side1, side2, side3));
    }

    public static double ThreeSidesSurface(double firstSide, double secondSide, double thirdSide)
    {
        double halfPerimeter = (firstSide + secondSide + thirdSide) / 2;
        double surface = Math.Sqrt(halfPerimeter * (halfPerimeter - firstSide) *
            (halfPerimeter - secondSide) * (halfPerimeter - thirdSide));

        return surface;
    }
}

