/*
    Write a program that converts a string to a sequence of Unicode character literals. 
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

        Console.WriteLine(result.ToString().ToLower());
    }
}

