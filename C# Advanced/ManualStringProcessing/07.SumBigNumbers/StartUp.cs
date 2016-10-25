/*
    You are given two lines - each can be a really big number (0 to 1050). 
    You must display the sum of these numbers.
*/

using System;

public class Startup
{
    public static void Main()
    {
        string firstNum = Console.ReadLine();
        string secondNum = Console.ReadLine();
        string result = string.Empty;
        int digit = 0;
        int digitToAdd = 0;

        int maxLen = Math.Max(firstNum.Length, secondNum.Length);

        for (int i = 1; i <= maxLen; i++)
        {
            if (firstNum.Length - i >= 0)
            {
                digit += firstNum[firstNum.Length - i] - '0';
            }

            if (secondNum.Length - i >= 0)
            {
                digit += secondNum[secondNum.Length - i] - '0';
            }

            digit += digitToAdd;

            if (digit > 9)
            {
                digitToAdd = digit / 10;
                digit = digit % 10;
            }

            result = digit + result;

            if (i==maxLen && digitToAdd!=0)
            {
                result = digitToAdd + result;
            }

            digit = 0;
        }

        Console.WriteLine(result);
    }
}

