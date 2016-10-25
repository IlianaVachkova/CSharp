/*
    The gravitational field of the Moon is approximately 17% of that on the Earth.
        -Write a program that calculates the weight of a man on the moon by a given weight W
        (as a floating-point number) on the Earth.
        -The weight W should be read from the console.
*/

using System;

public class Startup
{
    static void Main()
    {
        double weigth = Double.Parse(Console.ReadLine());
        double moonWeigth = 0.17 * weigth;

        Console.WriteLine("{0:0.000}", moonWeigth);
    }
}
