/*
    On the first line you are given the length of two sets n and m. On the next n + m 
    lines there are n numbers that are in the first set and m numbers that are in the 
    second one. Find all non-repeating element that appears in both of them, and print 
    them at the console:
        Set with length n = 4: {1, 3, 5, 7}
        Set with length m = 3: {3, 4, 5}
        Set that contains all repeating elements -> {3, 5}
*/

using System;
using System.Collections.Generic;

public class Startup
{
    public static void Main()
    {
        string[] inputLens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int n = int.Parse(inputLens[0]);
        int m = int.Parse(inputLens[1]);

        HashSet<int> nSet = new HashSet<int>();
        HashSet<int> mSet = new HashSet<int>();

        for (int i = 0; i < n; i++)
        {
            nSet.Add(int.Parse(Console.ReadLine()));
        }

        for (int i = 0; i < m; i++)
        {
            mSet.Add(int.Parse(Console.ReadLine()));
        }

        nSet.IntersectWith(mSet);

        foreach (var item in nSet)
        {
            Console.Write($"{item} ");
        }
    }
}

