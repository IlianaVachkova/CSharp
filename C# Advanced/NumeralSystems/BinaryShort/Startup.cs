/*
    Description:
    Write a program that shows the binary representation of given 16-bit signed integer number N (the C# type short).
    
    Input:
    On the only line you will receive a decimal number - N
    
    Output:
    Print the its binary representation on a single line
        There should be exactly 16 digits of output
*/

using System;
using System.Text;

public class Startup
{
    public static void Main()
    {
        short number = short.Parse(Console.ReadLine());
        StringBuilder result = new StringBuilder();

        for (int i = 15; i >= 0; i--)
        {
            result.Append((number >> i) & 1);
        }

        Console.WriteLine(result.ToString());
    }
}

