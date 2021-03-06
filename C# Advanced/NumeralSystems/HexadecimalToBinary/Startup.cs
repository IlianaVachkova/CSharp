﻿/*
    Description:
    Write a program to convert hexadecimal numbers to binary numbers.
    
    Input:
    On the only line you will receive a decimal number - N
        There will not be leading zeros
        Letters will be uppercase
    
    Output:
    Print the its binary representation on a single line
        There should not be leading zeros
*/

using System;

public class Startup
{
    public static void Main()
    {
        string hexNumber = Console.ReadLine();
        int step = 0;
        long decNumber = 0L;
        string result = string.Empty;

        for (int i = hexNumber.Length - 1; i >= 0; i--)
        {
            if ((hexNumber[i] - '0' >= 0) && (hexNumber[i] - '0' <= 9))
            {
                decNumber += (hexNumber[i] - '0') * (long)Math.Pow(16, step);
            }
            else if ((hexNumber[i] - '7' >= 10) && (hexNumber[i] - '7' <= 15))
            {
                decNumber += (hexNumber[i] - '7') * (long)Math.Pow(16, step);
            }
            step++;
        }

        while (decNumber != 0)
        {
            byte lastNumber = (byte)(decNumber % 2);
            result = lastNumber + result;
            decNumber /= 2;
        }

        Console.WriteLine(result);
    }
}

