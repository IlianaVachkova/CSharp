using System;

namespace SpiralMatrix
{
    public class Startup
    {
        public static void Main()
        {
            Console.Write("N=");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            GetMatrixFilled(matrix, n);
            PrintMatrix(matrix, n);
        }

        //Filling from left ro right
        static void GetMatrixFilled(int[,] matrix, int n)
        {
            int row = 0;
            int col = 0;

            for (int i = 1; i <= n; i++)
            {
                matrix[row, i - 1] = i;
            }
            col = n - 1;
            int num = n;
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
                        num++;
                        matrix[row, col] = num;
                    }
                    direction++;
                    direction %= 4;
                }
                n--;
            }
        }

        static void PrintMatrix(int[,] matrix, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,3}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}