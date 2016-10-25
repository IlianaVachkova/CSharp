/*
    Description:
    You are given a sequence of positive integer values written into a string, 
    separated by spaces. Write a function that reads these values from given string 
    and calculates their sum. Write a program that reads a string of positive integers
    separated by spaces and prints their sum.
    
    Input:
    On the only line you will receive a string consisted of positive integers
    
    Output:
    Print the sum of the integers
*/

using System;

public class Startup
{
    public static void Main()
    {
        string input = Console.ReadLine();
        Console.WriteLine(GetPrintSum(input));
    }

    public static int GetPrintSum(string input)
    {
        string[] numbers = input.Split(' ');
        int sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            int currentNumber = int.Parse(numbers[i]);
            sum += currentNumber;
        }

        return sum;
    }
}

