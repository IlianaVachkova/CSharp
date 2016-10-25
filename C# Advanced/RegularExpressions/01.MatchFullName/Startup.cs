/*
    Write a regular expression to match a valid full name. A valid full 
    name consists of two words, each word starts with a capital letter and 
    contains only lowercase letters afterwards; each word should be at least 
    two letters long; the two words should be separated by a single space. 
*/

using System;
using System.Text.RegularExpressions;

public class Startup
{
    public static void Main()
    {
        string line = Console.ReadLine();
        
        while (line!="end")
        {
            string pattern = @"([A-Z]){1}([a-z]+){1,} ([A-Z]){1}([a-z]+){1,}";
            Regex regex = new Regex(pattern);
            MatchCollection matches = Regex.Matches(line, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups[0].ToString());
            }

            line = Console.ReadLine();
        }
    }
}

