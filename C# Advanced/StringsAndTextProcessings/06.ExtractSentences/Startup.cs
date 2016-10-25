/*
    Description:
    Write a program that extracts from a given text all sentences containing given word.

    Input:
    On the first line you will receive a string - the word
    On the second line you will receive a string - the text

    Output:
    Print only the sentences containing the word on a single line
*/

using System;
using System.Text;

public class Startup
{
    public static void Main()
    {
        string givenWord = Console.ReadLine();
        string text = Console.ReadLine().Replace("...", "@");
        StringBuilder result = new StringBuilder();

        if (String.IsNullOrEmpty(text) || String.IsNullOrEmpty(givenWord))
        {
            return;
        }

        string[] sentences = text.Split('.');

        foreach (var sentence in sentences)
        {
            string[] words = sentence.Split(new char[] { ' ', ',', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'}, 
                StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in words)
            {
                if (string.Compare(givenWord, word, true) == 0)
                {
                    result.Append(sentence.Replace("@", "...") + '.');
                    break;
                }
            }
        }

        Console.WriteLine(result.ToString());
    }
}
