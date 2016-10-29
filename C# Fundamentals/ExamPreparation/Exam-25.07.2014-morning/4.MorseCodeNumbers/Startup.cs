using System;

namespace _4.MorseCodeNumbers
{
    public class Startup
    {
        public static void Main()
        {
            string number = Console.ReadLine();
            int nSum = 0;

            string[] morseCodeNumbers = { "-----|", ".----|", "..---|", "...--|", "....-|", ".....|" };

            for (int i = 0; i < number.Length; i++)
            {
                nSum += (number[i] - '0');
            }

            int count = 0;
            for (int i = 0; i <= 5; i++)
            {
                for (int j = 0; j <= 5; j++)
                {
                    for (int l = 0; l <= 5; l++)
                    {
                        for (int k = 0; k <= 5; k++)
                        {
                            for (int m = 0; m <= 5; m++)
                            {
                                for (int p = 0; p <= 5; p++)
                                {
                                    if (i * j * l * k * m * p == nSum)
                                    {
                                        Console.WriteLine(morseCodeNumbers[i] + morseCodeNumbers[j] + morseCodeNumbers[l]
                                                    + morseCodeNumbers[k] + morseCodeNumbers[m] + morseCodeNumbers[p]);

                                        count += 1;
                                    }
                                }

                            }
                        }
                    }
                }
            }

            if (count == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
