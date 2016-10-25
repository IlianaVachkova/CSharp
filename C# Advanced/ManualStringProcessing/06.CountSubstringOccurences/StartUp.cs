/*
    Write a program to find how many times a given string appears in a given text as 
    substring. The text is given at the first input line. The search string is given 
    at the second input line. The output is an integer number. Please ignore the character 
    casing. Overlapping between occurrences is allowed. 
*/

using System;

public class Startup
{
    public static void Main()
    {
        string text = Console.ReadLine().ToLower();
        string word = Console.ReadLine().ToLower();

        string subStr = string.Empty;
        int wordOccur = 0;
        for (int i = 0; i < text.Length-word.Length; i++)
        {
            subStr = text.Substring(i, word.Length);

            if (subStr==word)
            {
                wordOccur++;
            }
        }

        Console.WriteLine(wordOccur);
    }
}