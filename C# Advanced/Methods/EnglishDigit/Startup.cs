/*
    Description:
    Write a method that returns the last digit of given integer as an English word. 
    Write a program that reads a number and prints the result of the method.
    
    Input:
    On the first line you will receive a number
    
    Output:
    Print the last digit of the number as an English word
*/

using System;

public class Startup
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int lastDigit = number % 10;

        Console.WriteLine(DigitAsWord(lastDigit));
    }

    public static string DigitAsWord(int digit)
    {
        string word = string.Empty;

        switch(digit)
        {
            case 0: word = "zero"; break;
            case 1: word = "one"; break;
            case 2: word = "two"; break;
            case 3: word = "three"; break;
            case 4: word = "four"; break;
            case 5: word = "five"; break;
            case 6: word = "six"; break;
            case 7: word = "seven"; break;
            case 8: word = "eight"; break;
            case 9: word = "nine"; break;
        }

        return word;
    }
}