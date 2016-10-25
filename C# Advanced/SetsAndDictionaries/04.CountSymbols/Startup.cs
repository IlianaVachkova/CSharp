/*
    Write a program that reads some text from the console and counts the occurrences 
    of each character in it. Print the results in alphabetical (lexicographical) order.
*/

using System;
using System.Collections.Generic;

public class Startup
{
    public static void Main()
    {
        string text = Console.ReadLine();
        SortedDictionary<char, int> charOccurances = new SortedDictionary<char, int>();
        char currentSymbol = '@';

        for (int i = 0; i < text.Length; i++)
        {
            currentSymbol = text[i];

            if (!charOccurances.ContainsKey(currentSymbol))
            {
                charOccurances.Add(currentSymbol, 0);
            }

            charOccurances[currentSymbol]++;
        }

        foreach (var ch in charOccurances)
        {
            Console.WriteLine($"{ch.Key}: {ch.Value} time/s");
        }
    }
}

