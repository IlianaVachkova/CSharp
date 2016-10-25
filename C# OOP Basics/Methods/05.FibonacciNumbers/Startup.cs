using System;

public class Startup
{
    public static void Main()
    {
        int startPos = int.Parse(Console.ReadLine());
        int endPos = int.Parse(Console.ReadLine());
        Fibonacci fibSequence = new Fibonacci();
        var generateFibSeq = fibSequence.GenerateFibNums(endPos);
        var resultSeq = fibSequence.GetNumbersInRange(startPos, endPos);
        Console.WriteLine(string.Join(", ", resultSeq));
    }
}
