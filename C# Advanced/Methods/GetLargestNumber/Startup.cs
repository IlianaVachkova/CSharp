/*
    Description:
    Write a method GetMax() with two parameters that returns the larger of two integers. 
    Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().
    
    Input:
    On the first line you will receive 3 integers separated by spaces
    
    Output:
    Print the largest of them
*/

using System;

public class Startup
{
    public static void Main()
    {
        string[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int number1 = int.Parse(numbers[0]);
        int number2 = int.Parse(numbers[1]);
        int number3 = int.Parse(numbers[2]);

        int maxNum = GetMax(number1, number2);
        if (number3 > maxNum)
        {
            Console.WriteLine(number3);
        }
        else
        {
            Console.WriteLine(maxNum);
        }
    }

    public static int GetMax(int num1, int num2)
    {
        if (num1 > num2)
        {
            return num1;
        }
        else
        {
            return num2;
        }
    }
}

