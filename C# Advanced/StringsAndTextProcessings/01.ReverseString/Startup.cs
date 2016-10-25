/*
    Description:
    Write a program that reads a string, reverses it and prints the result on the console.

    Input:    
    On the only line you will receive a string

    Output:    
    Print the string in reverse on a single line
*/

using System;
using System.Text;

public class Startup
{
    public static void Main()
    {
        string input = Console.ReadLine();
        StringBuilder reversedInput = new StringBuilder();

        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversedInput.Append(input[i]);
        }

        Console.WriteLine(reversedInput.ToString());
    }
}

