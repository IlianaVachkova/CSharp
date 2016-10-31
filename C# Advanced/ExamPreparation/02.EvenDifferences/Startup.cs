using System;
using System.Linq;
using System.Numerics;

public class Startup
{
    public static void Main()
    {
        long[] sequence = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => long.Parse(x))
            .ToArray();

        long step = 1;
        BigInteger evenDiffSum = 0;
        BigInteger absDiff = 0;

        while (step < sequence.Length)
        {
            absDiff = Math.Abs(sequence[step] - sequence[step - 1]);

            if (absDiff % 2 == 0)
            {
                evenDiffSum += absDiff;
                step += 2;
            }
            else
            {
                step++;
            }
        }

        Console.WriteLine(evenDiffSum);
    }
}

