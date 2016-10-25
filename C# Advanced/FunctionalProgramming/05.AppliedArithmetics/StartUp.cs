/*
    Write a program that executes some mathematical operations on a given collection. 
    On the first line you are given a list of numbers. On the next lines you are passed 
    different commands that you need to apply to all numbers in the list: "add" -> add 1 
    to each number; "multiply" -> multiply each number by 2; "subtract" -> subtract 1 from 
    each number; “print” -> print the collection. The input will end with and "end" command, 
    after which you need to print the result. Use functions.
*/

using System;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x)).ToArray();
        string command = Console.ReadLine();

        while (command != "end")
        {

            switch (command)
            {
                case "add": break;
                case "subtract": break;
                case "multiply": break;
                case "print": break;
            }
            command = Console.ReadLine();
        }
    }

    public static void Print(int element)
    {
        Console.Write(element + " ");
    }
}

