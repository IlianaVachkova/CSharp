/*
    Description:
    Write a program that reads from the console a string of maximum 20 characters. 
    If the length of the string is less than 20, the rest of the characters should be filled with *.
    
    Input:
    On the only line you will receive a string
    
    Output:
    Output a string with length 20
*/

using System;

public class Startup
{
    public static void Main()
    {
        string input = Console.ReadLine().Replace(@"\", string.Empty);
        int len = input.Length;

        if (len < 20)
        {
            Console.WriteLine(input + new string('*', 20 - len));
        }
        else
        {
            Console.WriteLine(input.Substring(0, 20));
        }
    }
}
