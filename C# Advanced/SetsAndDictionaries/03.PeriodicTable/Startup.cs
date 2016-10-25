/*
    You are given an n number of chemical compounds. You need to keep track of all 
    chemical elements used in the compounds and at the end print all unique ones in 
    ascending order:

        Input:	Output:
        4       Ce Ee Mo O
        Ce O
        Mo O Ce
        Ee
        Mo	
*/

using System;
using System.Collections.Generic;

public class Startup
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        SortedSet<string> uniqueElements = new SortedSet<string>();

        for (int i = 0; i < n; i++)
        {
            string[] currentLine = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int j = 0; j < currentLine.Length; j++)
            {
                uniqueElements.Add(currentLine[j]);
            }
        }

        foreach (var item in uniqueElements)
        {
            Console.Write($"{item} ");
        }
    }
}

