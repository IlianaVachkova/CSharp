/*
    You are given a lower and an upper bound for a range of integer numbers. 
    Then a command specifies if you need to list all even or odd numbers in 
    the given range. Use Predicate<T>.
*/

using System;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        long[] range = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => long.Parse(x)).ToArray();
        long from = Math.Min(range[0], range[1]);
        long to = Math.Max(range[0], range[1]);
        string command = Console.ReadLine();

        Predicate<long> isEven =
            x => x % 2 == 0;

        if (command == "odd")
        {
            for (long i = from; i <= to; i++)
            {
                if (!isEven(i))
                {
                    Console.Write(i + " ");
                }
            }
        }
        else if (command == "even")
        {
            for (long i = from; i <= to; i++)
            {
                if (isEven(i))
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}



