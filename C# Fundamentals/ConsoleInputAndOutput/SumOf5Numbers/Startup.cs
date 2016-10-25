/*
    Write a program that reads 5 integer numbers from the console and prints their sum.
*/

using System;

public class Startup
{
    static void Main()
    {
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());
        int number3 = int.Parse(Console.ReadLine());
        int number4 = int.Parse(Console.ReadLine());
        int number5 = int.Parse(Console.ReadLine());
        int sum = number1 + number2 + number3 + number4 + number5;
        Console.WriteLine(sum);
    }
}

