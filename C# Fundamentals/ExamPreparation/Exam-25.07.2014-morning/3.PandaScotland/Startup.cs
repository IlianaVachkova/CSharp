using System;

namespace PandaScotland
{
    public class Startup
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int letterLeft = 65;
            int letterRight = 66;

            for (int i = 0; i < n / 2; i++)
            {
                if (letterLeft == 90)
                {
                    letterRight = 65;
                }

                Console.WriteLine(new string('~', i) + (char)letterLeft + new string('#', n - 2 - 2 * i) + (char)letterRight + new string('~', i));

                if (letterRight == 90)
                {
                    letterLeft = 65;
                    letterRight = 66;
                }
                else if (letterRight == 65)
                {
                    letterLeft = 66;
                    letterRight = 67;
                }
                else
                {
                    letterLeft += 2;
                    letterRight += 2;
                }
            }

            Console.WriteLine(new string('-', n / 2) + (char)letterLeft + new string('-', n / 2));

            letterRight = letterLeft + 1;
            letterLeft = letterRight + 1;

            for (int i = n / 2 - 1; i >= 0; i--)
            {
                if (letterRight == 90)
                {
                    letterLeft = 65;
                }

                Console.WriteLine(new string('~', i) + (char)letterRight + new string('#', n - 2 - 2 * i) + (char)letterLeft + new string('~', i));

                if (letterLeft == 90)
                {
                    letterRight = 65;
                }
                else if (letterLeft == 65)
                {
                    letterRight = 66;
                    letterLeft = 67;
                }
                else
                {
                    letterRight += 2;
                    letterLeft += 2;
                }
            }
        }
    }
}
