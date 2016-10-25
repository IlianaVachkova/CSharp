/*
    Write a custom comparator that sorts all even numbers before all odd ones 
    in ascending order. Pass it to an Array.sort() function and print the result.
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;

public class Startup
{
    public static void Main(string[] args)
    {
        var numbers = Regex.Split(Console.ReadLine().Trim(), "\\s+").Select(int.Parse).ToArray();
        Array.Sort(numbers, Comparison);
        Console.WriteLine(string.Join(" ", numbers));
    }

    private static int Comparison(int a, int b)
    {
        var first = Math.Abs(a) % 2;
        var second = Math.Abs(b) % 2;

        if (first != second)
        {
            return first.CompareTo(second);
        }

        return a.CompareTo(b);
    }
}
