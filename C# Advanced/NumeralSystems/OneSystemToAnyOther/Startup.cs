/*
    Description:
    Write a program to convert the number N from any numeral system of given base s to any other numeral system of base d.
    
    Input:
    On the first line you will receive the number s
    On the second line you will receive a number in base s - N
        There will not be leading zeros
    On the third line you will receive the number d
    
    Output:
    Print N in base d
        There should not be leading zeros
        Use uppercase letters
*/

using System;

public class Startup
{
    public static void Main()
    {
        ulong from = ulong.Parse(Console.ReadLine());
        string input = Console.ReadLine().ToUpper();
        ulong to = ulong.Parse(Console.ReadLine());

        string result = string.Empty;

        ulong decimalNumber = 0;
        int length = input.Length;

        for (int i = 0; i < length; i++)
        {
            char current = input[length - i - 1];
            ulong number =(ulong)(current - '0');
            ulong letter =(ulong)(current - '7');
            if (number < 10)
            {
                decimalNumber += number * Power(from, i);
            }
            else
            {
                decimalNumber += letter * Power(from, i);
            }
        }

        while (decimalNumber > 0)
        {
            ulong current = decimalNumber % to;
            char letter = (char)(current + 55);
            if (current > 9)
            {
                result = letter + result;
            }
            else
            {
                result = current + result;
            }
            decimalNumber /= to;
        }

        Console.WriteLine(result);
    }

    public static ulong Power(ulong number, int power)
    {
        ulong result = 1;

        for (int i = 0; i < power; i++)
        {
            result = result * number;
        }

        return result;
    }
}