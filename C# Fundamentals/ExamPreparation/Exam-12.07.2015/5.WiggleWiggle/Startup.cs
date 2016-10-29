using System;
using System.Linq;

namespace WiggleWiggle
{
    public class Startup
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string[] inputAsArr = input.Split(' ');
            long[] numbers = new long[inputAsArr.Length];

            for (int i = 0; i < inputAsArr.Length; i += 2)
            {
                numbers[i] = long.Parse(inputAsArr[i]);
                numbers[i + 1] = long.Parse(inputAsArr[i + 1]);

                char[] firstNumberAsString = Convert.ToString(numbers[i], 2).PadLeft(64, '0').ToArray();
                string firstResultNumber = string.Empty;

                char[] secondNumberAsString = Convert.ToString(numbers[i + 1], 2).PadLeft(64, '0').ToArray();
                string secondResultNumber = string.Empty;

                char temp;
                for (int bit = 1; bit < 64; bit++)
                {
                    if (bit % 2 == 1)
                    {
                        temp = firstNumberAsString[bit];
                        firstNumberAsString[bit] = secondNumberAsString[bit];
                        secondNumberAsString[bit] = temp;
                    }

                    if (firstNumberAsString[bit] == '0')
                    {
                        firstResultNumber += '1';
                    }
                    else if (firstNumberAsString[bit] == '1')
                    {
                        firstResultNumber += '0';
                    }

                    if (secondNumberAsString[bit] == '0')
                    {
                        secondResultNumber += '1';
                    }
                    else if (secondNumberAsString[bit] == '1')
                    {
                        secondResultNumber += '0';
                    }
                }

                long firstNumber = Convert.ToInt64(firstResultNumber, 2);
                long secondNumber = Convert.ToInt64(secondResultNumber, 2);

                Console.WriteLine("{0} {1}", firstNumber, firstResultNumber);
                Console.WriteLine("{0} {1}", secondNumber, secondResultNumber);
            }
        }
    }
}