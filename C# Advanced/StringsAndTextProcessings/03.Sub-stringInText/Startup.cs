/*
    Description:
    Write a program that finds how many times a sub-string is contained in a given text 
    (perform case insensitive search).
    
    Input:
    On the first line you will receive a string - the pattern
    On the second line you will receive a string - the text
    
    Output:
    Print a number on a single line
        The number of occurrences
*/

using System;

public class Startup
{
    public static void Main()
    {
        string pattern = Console.ReadLine().ToLower();
        string text = Console.ReadLine().ToLower();
        string subText = string.Empty;
        int countOccur = 0;

        for (int i = 0; i <= text.Length - pattern.Length; i++)
        {
            subText = text.Substring(i, pattern.Length);
            if (subText == pattern)
            {
                countOccur++;
            }
        }

        Console.WriteLine(countOccur);
    }
}

