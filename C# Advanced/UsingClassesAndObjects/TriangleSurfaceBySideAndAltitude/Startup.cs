/*
    Description:
    Write program that calculates the surface of a triangle by given a side and an altitude to it.
    
    Input:
    On the first line you will receive the length of a side of the triangle
    On the second line you will receive the altitude to that side
    
    Output:
    Print the surface of the rectangle with two digits of precision
*/

using System;

public class Startup
{
    public static void Main()
    {
        double side = double.Parse(Console.ReadLine());
        double altitude = double.Parse(Console.ReadLine());

        Console.WriteLine("{0:0.00}", SideAltitudeSurface(side, altitude));
    }

    public static double SideAltitudeSurface(double side, double altitude)
    {
        double surface = side * altitude / 2;

        return surface;
    }
}

