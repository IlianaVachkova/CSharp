/*
    Write a program that extracts from a given text all palindromes, e.g. ABBA, 
    lamal, exe and prints them on the console on a single line, separated by comma 
    and space. Use spaces, commas, dots, question marks and exclamation marks as word 
    delimiters. Print only unique palindromes, sorted lexicographically (small letters 
    are before big ones).
*/

using System;
using System.Collections.Generic;

public class Startup
{
    public static void Main()
    {
        string text = Console.ReadLine();
        string[] words = text.Split(new char[] { ' ', '.', '?', '!', ',' }, StringSplitOptions.RemoveEmptyEntries);

        SortedSet<string> palindromes = new SortedSet<string>();

        bool isPalindrome = true;
        for (int i = 0; i < words.Length; i++)
        {
            isPalindrome = true;

            string currentWord = words[i];

            for (int j = 1; j <= currentWord.Length / 2; j++)
            {
                if (currentWord[j - 1] != currentWord[currentWord.Length - j])
                {
                    isPalindrome = false;
                }
            }

            if (isPalindrome)
            {
                palindromes.Add(currentWord);
            }
        }

        Console.WriteLine("[" + String.Join(", ", palindromes) + "]");
    }
}

