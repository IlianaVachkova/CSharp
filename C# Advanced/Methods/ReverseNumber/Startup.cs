/*
    Description:
    Write a method that reverses the digits of a given decimal number.
    
    Input:
    On the first line you will receive a number
    
    Output:
    Print the given number with reversed digits
*/

using System;

public class Startup
{
    public static void Main()
    {
        string number = Console.ReadLine();

        Console.WriteLine(ReversedNumber(number));
    }

    public static string ReversedNumber(string number)
    {
        string reversedNum = string.Empty;

        for (int i = 0; i < number.Length; i++)
        {
            reversedNum = number[i] + reversedNum;
        }

        return reversedNum;
    }
}

