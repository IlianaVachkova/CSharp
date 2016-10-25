/*
    Write a program that takes a base-N number and converts it to a base-10 number (0 to 1050), where 2 <= N <= 10.
    The input consists of 1 line containing two numbers separated by a single space. The first number is the base N 
    to which you have to convert. The second one is the base N number to be converted. Do not use any built in 
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

        ConvertFromAnyOtherSystemToDecimal(number, baseSys);
    }

    public static BigInteger Power(ulong baseSys, ulong step)
    {
        ulong result = 1;

        for (ulong i = 0; i < step; i++)
        {
            result *= baseSys;
        }

        return result;
    }

    public static void ConvertFromAnyOtherSystemToDecimal(BigInteger number, ulong baseSys)
    {
        BigInteger convertedNumber = 0;
        ulong baseStep = 0;

        if (number==0)
        {
            Console.WriteLine(convertedNumber);
            return;
        }

        while (number > 0)
        {
            convertedNumber += number % 10 * Power(baseSys, baseStep);
            number /= 10;
            baseStep++;
        }

        Console.WriteLine(convertedNumber);
    }
}

