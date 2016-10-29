using System;

namespace _5.BitsAsCrossroads
{
    public class Startup
    {
        public static void Main()
        {
            int boardSize = int.Parse(Console.ReadLine());
            int[,] board = new int[boardSize, boardSize];
            int crossroadsCount = 0;

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }

                string[] lineAsArr = line.Split(' ');
                int row = int.Parse(lineAsArr[0]);
                int col = boardSize - 1 - int.Parse(lineAsArr[1]);

                int countUp = row + col + 2;
                for (int i = row; i >= 0; i--)
                {
                    for (int j = col; j >= 0; j--)
                    {
                        if ((i + j) == (countUp - 2))
                        {
                            if (board[i, j] == 1)
                            {
                                crossroadsCount += 1;
                            }

                            board[i, j] = 1;
                        }

                        if (row == 0 || col == 0)
                        {
                            break;
                        }
                    }

                    countUp -= 2;
                }

                int countDown = row + col;
                for (int i = row; i < boardSize; i++)
                {
                    for (int j = col; j < boardSize; j++)
                    {
                        if ((i + j) == (countDown))
                        {
                            if (board[i, j] == 1 && i != row && j != col)
                            {
                                crossroadsCount += 1;
                            }

                            board[i, j] = 1;
                        }

                        if (row == boardSize - 1 || col == boardSize - 1)
                        {
                            break;
                        }
                    }

                    countDown += 2;
                }

                for (int i = row; i >= 0; i--)
                {
                    for (int j = col; j < boardSize; j++)
                    {
                        if ((i + j) == (col + row))
                        {
                            if (board[i, j] == 1)
                            {
                                crossroadsCount += 1;
                            }
                            board[i, j] = 1;
                        }

                        if (row == 0 || col == boardSize - 1)
                        {
                            break;
                        }
                    }
                }

                for (int i = row; i < boardSize; i++)
                {
                    for (int j = col; j >= 0; j--)
                    {
                        if ((i + j) == (col + row))
                        {
                            if (board[i, j] == 1 && i != row && j != col)
                            {
                                crossroadsCount += 1;
                            }
                            board[i, j] = 1;
                        }

                        if (row == boardSize - 1 || col == 0)
                        {
                            break;
                        }
                    }
                }
            }

            string resultAsString = string.Empty;
            long resultAsNumber = 0;

            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    resultAsString += board[i, j];
                }

                resultAsNumber = Convert.ToInt64(resultAsString, 2);
                resultAsString = string.Empty;

                Console.WriteLine(resultAsNumber);
            }

            Console.WriteLine(crossroadsCount);
        }
    }
}
