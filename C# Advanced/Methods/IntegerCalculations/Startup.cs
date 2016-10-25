/*
    Description:
    Write methods to calculate minimum, maximum, average, sum and product of given 
    set of integer numbers. Use variable number of arguments. Write a program that 
    reads 5 elements and prints their minimum, maximum, average, sum and product.
    
    Input:
    On the first line you will receive 5 numbers separated by spaces
    
    Output:
    Print their minimum, maximum, average, sum and product
        Each on a new line
        The average value should be printed with two digits of precision
*/

using System;

public class Startup
{
    public static void Main(string[] args)
    {
        string[] numsAsStr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] array = new int[numsAsStr.Length];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(numsAsStr[i]);
        }

        Console.WriteLine(Min(array));
        Console.WriteLine(Max(array));
        Console.WriteLine("{0:0.00}", Average(array));
        Console.WriteLine(Sum(array));
        Console.WriteLine(Product(array));
    }

    public static long Sum(int[] elements)
    {
        long sum = 0;
        foreach (var item in elements)
        {
            sum += item;
        }

        return sum;
    }

    public static long Product(int[] elements)
    {
        long product = 1;
        foreach (var item in elements)
        {
            product *= item;
        }

        return product;
    }

    public static double Average(int[] elements)
    {
        double sum = 0.0;
        foreach (var item in elements)
        {
            sum += item;
        }

        return sum / (double)elements.Length;
    }

    public static int Min(int[] elements)
    {
        int min = elements[0];

        for (var i = 1; i < elements.Length; i++)
        {
            if (elements[i] < min)
            {
                min = elements[i];
            }
        }

        return min;
    }

    public static int Max(int[] elements)
    {
        int max = elements[0];

        for (var i = 1; i < elements.Length; i++)
        {
            if (elements[i] > max)
            {
                max = elements[i];
            }
        }

        return max;
    }
}

