using System;

public class Startup
{
    public static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());
        Number number = new Number(inputNumber);
        Console.WriteLine(number.LastDigit());
    }
}
