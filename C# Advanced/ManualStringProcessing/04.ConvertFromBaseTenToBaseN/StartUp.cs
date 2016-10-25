/*
    Write a program that takes a base-10 number (0 to 1050) and converts it to a base-N number, where 2 <= N <= 10.
    The input consists of 1 line containing two numbers separated by a single space. The first number is the base N 
    to which you have to convert. The second one is the base 10 number to be converted. Do not use any built in 
    converting functionality, try to write your own algorithm.
*/

using System;
using System.Numerics;

public class Startup
{
    public static void Main()
    {
        string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        ulong baseSys = ulong.Parse(input[0]);
        BigInteger number = BigInteger.Parse(input[1]);

        ConvertFromDecimalToAnyOtherSystem(number, baseSys);
    }

    public static void ConvertFromDecimalToAnyOtherSystem(BigInteger number, ulong baseSys)
    {
        string convertedNumber = string.Empty;

        if (number==0)
        {
            convertedNumber = "0";
            Console.WriteLine(convertedNumber);
            return;
        }

        while (number > 0)
        {
            convertedNumber = number % baseSys + convertedNumber;
            number /= baseSys;
        }

        Console.WriteLine(convertedNumber);
    }

}

