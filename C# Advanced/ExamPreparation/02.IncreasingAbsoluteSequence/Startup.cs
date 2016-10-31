using System;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        int numOfLines = int.Parse(Console.ReadLine());

        for (int i = 0; i < numOfLines; i++)
        {
            long[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => long.Parse(x))
                .ToArray();

            int pos = 1;
            long firstAbsDiff = Math.Abs(numbers[pos] - numbers[pos - 1]);
            long secondAbsDiff = 0;
            bool isIncreasing = true;

            while (pos < numbers.Length)
            {
                secondAbsDiff = Math.Abs(numbers[pos] - numbers[pos - 1]);

                if (firstAbsDiff > secondAbsDiff || Math.Abs(firstAbsDiff - secondAbsDiff) > 1)
                {
                    isIncreasing = false;
                    break;
                }
                else
                {
                    isIncreasing = true;
                }

                firstAbsDiff = secondAbsDiff;

                pos++;
            }

            if (isIncreasing)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}

