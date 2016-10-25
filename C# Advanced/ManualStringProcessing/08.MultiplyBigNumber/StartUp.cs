/*
    You are given two lines - the first one can be a really big number (0 to 1050). 
    The second one will be a single digit number (0 to 9). You must display the product 
    of these numbers.
*/

using System;

public class Startup
{
    public static void Main()
    {
        string number = Console.ReadLine();
        char multiplier = (char)Console.Read();
        string result = string.Empty;
        ulong product = 1;
        ulong digit = 0;
        ulong digitToAdd = 0;

        for (int i = number.Length - 1; i >= 0; i--)
        {
            product = (ulong)(number[i] - '0') * (ulong)(multiplier - '0') + digitToAdd;
            digit = product % 10;
            digitToAdd = product / 10;

            result = digit + result;
        }

        if (digitToAdd != 0)
        {
            result = digitToAdd + result;
        }

        Console.WriteLine(result);
    }
}

