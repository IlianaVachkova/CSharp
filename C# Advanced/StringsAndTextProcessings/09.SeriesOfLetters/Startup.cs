/*
    Description:
    Write a program that reads a string from the console and replaces all series 
    of consecutive identical letters with a single one.
    
    Input:
    On the only input line you will receive a string
    
    Output:
    Print the string without consecutive identical letters
*/

using System;
using System.Text;

public class Startup
{
    public static void Main()
    {
        string input = Console.ReadLine();
        StringBuilder result = new StringBuilder();

        char current = input[0];
        result.Append(current);

        for (int i = 1; i < input.Length; i++)
        {
            if (current != input[i])
            {
                current = input[i];
                result.Append(current);
            }
        }

        Console.WriteLine(result.ToString());
    }
}

