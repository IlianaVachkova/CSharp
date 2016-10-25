using System;

public class Startup
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        var result = new Number(number);
        Console.WriteLine(result);
    }
}
