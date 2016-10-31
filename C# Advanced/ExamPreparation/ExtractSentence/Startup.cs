﻿using System;
using System.Linq;

public class Startup
{
    public static char[] ExtractNonLetterSeparators(string input)
    {
        char[] separators = input.Where(c => !char.IsLetter(c))
                                 .Distinct()
                                 .ToArray();
        return separators;
    }

    public static void Main()
    {
        string word = Console.ReadLine();
        string text = Console.ReadLine();

        string[] splitted = text.Split(new char[] { '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
        char[] separators = ExtractNonLetterSeparators(text);

        foreach (var sent in splitted)
        {
            string[] words = sent.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                if (word.ToLower() == words[i].ToLower().Trim())
                {
                    Console.Write(sent + ".");
                    break;
                }
            }
        }
    }
}