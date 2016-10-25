using System;

public class Startup
{
    public static void Main()
    {
        decimal recievedNum = decimal.Parse(Console.ReadLine());
        DecimalNumber number = new DecimalNumber(recievedNum);
        Console.WriteLine(number.DigitsInReversedOrder());
    }
}
