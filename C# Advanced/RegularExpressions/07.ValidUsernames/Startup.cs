/*
    You are part of the back-end development team of the next Facebook. You are given a line of usernames, between one 
    of the following symbols: space, “/”, “\”, “(“, “)”. First you have to export all valid usernames. A valid username 
    starts with a letter and can contain only letters, digits and “_”. It cannot be less than 3 or more than 25 symbols 
    long. Your task is to sum the length of every 2 consecutive valid usernames and print on the console the 2 valid 
    usernames with biggest sum of their lengths, each on a separate line. 
    
    Input
    The input comes from the console. One line will hold all the data. It will hold usernames, divided by the symbols: 
    space, “/”, “\”, “(“, “)”. 
    The input data will always be valid and in the format described. There is no need to check it explicitly.
    
    Output
    Print at the console the 2 consecutive valid usernames with the biggest sum of their lengths each on a separate 
    line. If there are 2 or more couples of usernames with the same sum of their lengths, print he left most.
*/

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class StartUp
{
    public static void Main()
    {
        string input = Console.ReadLine();
        string[] words = input.Split(new char[] { '/', '\\', '(', ')', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        List<string> validNames = new List<string>();
        string pattern = @"\b[a-zA-Z]([a-zA-Z0-9_]{2,24})$";
        Regex regex = new Regex(pattern);

        for (int i = 0; i < words.Length; i++)
        {
            if (regex.IsMatch(words[i]))
            {
                validNames.Add(words[i]);
            }
        }

        int biggestSum = validNames[0].Length + validNames[1].Length;
        int startIndex = 0;
        int currentSum = 0;

        for (int i = 1; i < validNames.Count-1; i++)
        {
            currentSum = validNames[i].Length + validNames[i + 1].Length;

            if (currentSum>biggestSum)
            {
                biggestSum = currentSum;
                startIndex = i;
            }
        }

        Console.WriteLine(validNames[startIndex]);
        Console.WriteLine(validNames[startIndex+1]);
    }
}
