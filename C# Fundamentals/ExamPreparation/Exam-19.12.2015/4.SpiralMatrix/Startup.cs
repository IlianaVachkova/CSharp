using System;

namespace SpiralMatrix
{
    public class Startup
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int nPrint = n;
            int[,] matrix = new int[n, n];

            string input = Console.ReadLine();
            string inputLowerCase = input.ToLower();

            int row = 0;
            int col = 0;
            int strPositionCount = -1;
            for (int i = 0; i < n; i++)
            {
                strPositionCount++;

                if (i % inputLowerCase.Length == 0)
                {
                    strPositionCount = 0;
                }
                matrix[row, i] = (inputLowerCase[strPositionCount] - 96) * 10;

            }
            col = n - 1;
            int direction = 0;

            while (n > 0)
            {
                for (int repeats = 0; repeats < 2; repeats++)
                {
                    for (int depth = 0; depth < n - 1; depth++)
                    {
                        switch (direction)
                        {
                            case 0:
                                row++;
                                break;
                            case 1:
                                col--;
                                break;
                            case 2:
                                row--;
                                break;
                            case 3:
                                col++;
                                break;
                            default:
                                break;
                        }
                        strPositionCount++;
                        if (strPositionCount == inputLowerCase.Length)
                        {
                            strPositionCount = 0;
                        }
                        matrix[row, col] = (inputLowerCase[strPositionCount] - 96) * 10;
                    }
                    direction++;
                    direction %= 4;
                }
                n--;
            }

            int sum = 0;
            int maxSum = 0;
            int rowWithMaxSum = 0;
            for (int i = 0; i < nPrint; i++)
            {
                for (int j = 0; j < nPrint; j++)
                {
                    sum += matrix[i, j];
                }
                if (sum > maxSum)
                {
                    maxSum = sum;
                    rowWithMaxSum = i;
                }
                sum = 0;
            }

            Console.WriteLine("{0} - {1}", rowWithMaxSum, maxSum);
        }
    }
}