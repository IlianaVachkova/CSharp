/*
    Description:
    Write a method that multiplies a number represented as an array of digits by 
    a given integer number. Write a program to calculate N!.
    
    Input:
    On the first line you will receive the number N
    
    Output:
    Print N!
*/

using System;
using System.Numerics;

public class Startup
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(MultiplyNumDigits(number));
    }

    public static int[] NumberToArray(int number)
    {
        int[] result = new int[number];

        for (int i = 0; i < number; i++)
        {
            result[i] = i + 1;
        }

        return result;
    }

    public static BigInteger MultiplyNumDigits(int number)
    {
        BigInteger result = 1;
        int[] numAsArr = NumberToArray(number);

        for (int i = 0; i < numAsArr.Length; i++)
        {
            result *= numAsArr[i];
        }

        return result;
    }
}

