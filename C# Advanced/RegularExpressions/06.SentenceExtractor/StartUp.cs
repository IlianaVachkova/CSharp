/*
    Write a program that reads a keyword and some text from the console and prints all sentences 
    from the text, containing that word. A sentence is any sequence of words ending with '.', '!' 
    or '?'. 
*/

using System;
using System.Text.RegularExpressions;

public class StartUp
{
    public static void Main()
    {
        string wordPattern = Console.ReadLine();
        string pattern = @"(.*?)*\b(" + Regex.Escape(wordPattern) + @")(.*?)*(\.|\?|!)\s";
        string text = Console.ReadLine();

        Regex regex = new Regex(pattern);
        MatchCollection collection = regex.Matches(text);

        foreach (Match match in collection)
        {
            Console.WriteLine(match.Groups[0]);
        }
    }
}