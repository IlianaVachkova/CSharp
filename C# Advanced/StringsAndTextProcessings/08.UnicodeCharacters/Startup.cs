/*
    Description:
    Write a program that converts a string to a sequence of C# Unicode character literals.
    
    Input:
    On the only input line you will receive a string
    
    Output:
    Print the string in C# Unicode character literals on a single line
*/

using System;
using System.Text;

public class Startup
{
    public static void Main()
    {
        string input = Console.ReadLine();
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            result.Append(string.Format("\\u{0:X4}", (int)(input[i])));
        }

        Console.WriteLine(result.ToString());
    }
}

