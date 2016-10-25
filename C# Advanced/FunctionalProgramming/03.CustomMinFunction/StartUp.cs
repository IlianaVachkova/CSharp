/*
    Write a simple program that reads from the console a set of numbers and prints 
    back onto the console the smallest number from the collection. Use Func<T, T>.
*/

using System;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x)).ToArray();

        Func<int[], int> minNumber = MinNum;
        Console.WriteLine(minNumber(numbers));
    }

    public static int MinNum(int[] array)
    {
        return array.Min();
    }
}

