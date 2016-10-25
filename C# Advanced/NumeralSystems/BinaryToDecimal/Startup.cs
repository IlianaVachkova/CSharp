/*
    Description:
    Write a program that converts a binary number N to its decimal representation.
    
    Input:
    On the only line you will receive a binary number - N
    There will not be leading zeros
    
    Output:
    Print the decimal representation of N on a single line
        There should not be leading zeros
*/

using System;

public class Startup
{
    public static void Main()
    {
        string binNumber = Console.ReadLine();
        int step = 0;
        long decNumber = 0;
        for (int i = binNumber.Length - 1; i >= 0; i--)
        {
            decNumber += (binNumber[i] - '0') * (long)Math.Pow(2, step);
            step++;
        }

        Console.WriteLine(decNumber);
    }
}
