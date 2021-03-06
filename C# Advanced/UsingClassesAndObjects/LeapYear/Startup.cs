﻿/*
    Description:
    Write a program that reads a year from the console and checks whether it is a leap one.
        Hint: Use System.DateTime.
    
    Input:
    On the only line you will receive a number - the year
    
    Output:
    Print "Leap" or "Common" on a single line depending on the year
*/

using System;

public class Startup
{
    public static void Main()
    {
        int year = int.Parse(Console.ReadLine());
        bool isLeap = DateTime.IsLeapYear(year);

        if (isLeap)
        {
            Console.WriteLine("Leap");
        }
        else
        {
            Console.WriteLine("Common");
        }
    }
}

