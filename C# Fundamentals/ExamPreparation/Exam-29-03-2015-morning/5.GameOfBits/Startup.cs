using System;

namespace GameOfBits
{
    public class Startup
    {
        public static void Main()
        {
            uint number = uint.Parse(Console.ReadLine());
            string numberAsString = Convert.ToString(number, 2).PadLeft(32, '0');
            string resultNumber = string.Empty;

            while (true)
            {
                string command = Console.ReadLine();
                resultNumber = string.Empty;

                if (command == "Game Over!")
                {
                    break;
                }

                if (command == "Odd")
                {
                    for (int i = 1; i < numberAsString.Length; i += 2)
                    {
                        resultNumber += numberAsString[i];
                    }
                }
                else if (command == "Even")
                {
                    for (int i = 0; i < numberAsString.Length; i += 2)
                    {
                        resultNumber += numberAsString[i];
                    }
                }

                numberAsString = resultNumber;
            }

            int onesCount = 0;

            for (int i = 0; i < numberAsString.Length; i++)
            {
                if (numberAsString[i] == '1')
                {
                    onesCount += 1;
                }
            }

            Console.WriteLine("{0} -> {1}", Convert.ToUInt32(numberAsString, 2), onesCount);
        }
    }
}