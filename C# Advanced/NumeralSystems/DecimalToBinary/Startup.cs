/*
    Description:
    Write a program that converts a decimal number N to its binary representation.
    
    Input:
    On the only line you will receive a decimal number - N
    There will not be leading zeros
    
    Output:
    Print the binary representation of N on a single line
        There should not be leading zeros
*/

using System;

public class Startup
{
    public static void Main()
    {
        long decNumber = long.Parse(Console.ReadLine());
        string result = String.Empty;

        while (decNumber != 0)
        {
            byte binaryReminder = (byte)(decNumber % 2);
            result = binaryReminder + result;
            decNumber /= 2;
        }

        Console.WriteLine(result);
    }
}

