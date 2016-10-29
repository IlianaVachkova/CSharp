using System;

namespace _5.ShuffleBits
{
    public class Startup
    {
        public static void Main()
        {
            uint firstNumber = uint.Parse(Console.ReadLine());
            uint secondNumber = uint.Parse(Console.ReadLine());

            string firstNumberAsString = Convert.ToString(firstNumber, 2).PadLeft(32, '0');
            string secondNumberAsString = Convert.ToString(secondNumber, 2).PadLeft(32, '0');

            ulong resultAsNumber;
            string resultAsString = string.Empty;

            if (firstNumber >= secondNumber)
            {
                for (int i = 0; i < 32; i++)
                {
                    resultAsString += firstNumberAsString[i];
                    resultAsString += secondNumberAsString[i];
                }
            }
            else if (secondNumber > firstNumber)
            {
                for (int i = 0; i < 31; i += 2)
                {
                    resultAsString += firstNumberAsString[i];
                    resultAsString += firstNumberAsString[i + 1];
                    resultAsString += secondNumberAsString[i];
                    resultAsString += secondNumberAsString[i + 1];
                }
            }

            resultAsNumber = (ulong)Convert.ToInt64(resultAsString, 2);

            Console.WriteLine(resultAsNumber);
        }
    }
}
