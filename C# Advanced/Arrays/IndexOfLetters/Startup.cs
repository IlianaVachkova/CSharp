/*
    Write a program that creates an array containing all letters from the alphabet (a-z). 
    Read a word from the console and print the index of each of its letters in the array.
*/

using System;

public class Startup
{
    public static void Main()
    {
        string word = Console.ReadLine();
        char[] letters = new char[26];

        int asciiNumber = 97;
        for (int i = 0; i < 26; i++)
        {
            letters[i] = (char)asciiNumber;
            asciiNumber += 1;
        }

        for (int i = 0; i < word.Length; i++)
        {
            Console.WriteLine(word[i] - 97);
        }
    }
}

