using System;
using System.Linq;

namespace _5.BitSwapper
{
    public class Startup
    {
        public static void Main()
        {
            int[,] matrix = new int[4, 32];
            for (int row = 0; row < 4; row++)
            {
                uint number = uint.Parse(Console.ReadLine());
                for (int col = 0; col < 32; col++)
                {
                    if ((number & (1 << col)) != 0)
                    {
                        matrix[row, col] = 1;
                    }
                }
            }

            while (true)
            {
                string command1 = Console.ReadLine();
                string command2 = Console.ReadLine();

                if (command1 == "End")
                {
                    break;
                }

                int[] firstNumberParameters = command1.Split(' ').Select(int.Parse).ToArray();
                int[] secondNumberParameters = command2.Split(' ').Select(int.Parse).ToArray();

                int temp = 0;
                for (int i = 0; i < 4; i++)
                {
                    temp = matrix[firstNumberParameters[0], 4 * firstNumberParameters[1] + i];
                    matrix[firstNumberParameters[0], 4 * firstNumberParameters[1] + i] =
                        matrix[secondNumberParameters[0], 4 * secondNumberParameters[1] + i];
                    matrix[secondNumberParameters[0], 4 * secondNumberParameters[1] + i] = temp;
                }
            }

            string resultNumberAsStr = string.Empty;
            uint resultNumber = 0;
            for (int row = 0; row < 4; row++)
            {
                for (int col = 31; col >=0; col--)
                {
                    resultNumberAsStr += matrix[row, col];
                }

                resultNumber = Convert.ToUInt32(resultNumberAsStr, 2);
                Console.WriteLine(resultNumber);

                resultNumberAsStr = string.Empty;
            }
        }
    }
}
