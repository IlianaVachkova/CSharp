using System;

namespace _5.GameOfLife_2
{
    public class Startup
    {
        public static void Main()
        {
            int[,] matrixInput = new int[10, 10];
            int[,] matrixResult = new int[10, 10];

            int numberOfCoordinates = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCoordinates; i++)
            {
                int row = int.Parse(Console.ReadLine());
                int col = int.Parse(Console.ReadLine());

                matrixInput[row, 9 - col] = 1;
            }

            int startRow, endRow, startCol, endCol;
            for (int row = 0; row < 10; row++)
            {
                for (int col = 0; col < 10; col++)
                {
                    if (row == 0)
                    {
                        startRow = 0;
                    }
                    else
                    {
                        startRow = row - 1;
                    }

                    if (row == 9)
                    {
                        endRow = 9;
                    }
                    else
                    {
                        endRow = row + 1;
                    }

                    if (col == 0)
                    {
                        startCol = 0;
                    }
                    else
                    {
                        startCol = col - 1;
                    }

                    if (col == 9)
                    {
                        endCol = 9;
                    }
                    else
                    {
                        endCol = col + 1;
                    }

                    int countZeros = 0;
                    int countOnes = 0;
                    for (int i = startRow; i <= endRow; i++)
                    {
                        for (int j = startCol; j <= endCol; j++)
                        {
                            if (matrixInput[i, j] == 0)
                            {
                                countZeros += 1;
                            }
                            else if (matrixInput[i, j] == 1)
                            {
                                countOnes += 1;
                            }
                        }
                    }

                    if (matrixInput[row, col] == 1)
                    {
                        countOnes -= 1;
                    }
                    else if (matrixInput[row, col] == 0)
                    {
                        countZeros -= 1;
                    }

                    if (matrixInput[row, col] == 0 && countOnes == 3)
                    {
                        matrixResult[row, col] = 1;
                    }
                    else if (matrixInput[row, col] == 1)
                    {
                        if (countOnes == 1)
                        {
                            matrixResult[row, col] = 0;
                        }
                        else if (countOnes == 2 || countOnes == 3)
                        {
                            matrixResult[row, col] = 1;
                        }
                        else if (countOnes >= 4)
                        {
                            matrixResult[row, col] = 0;
                        }
                    }
                }
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(matrixResult[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
