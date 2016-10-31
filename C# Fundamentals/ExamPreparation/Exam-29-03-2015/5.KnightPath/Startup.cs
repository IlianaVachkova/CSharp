using System;

namespace _5.KnightPath
{
    public class Startup
    {
        public static void Main()
        {
            int[,] board = new int[8, 8];
            board[0, 7] = 1;
            int row = 0;
            int col = 7;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "stop")
                {
                    break;
                }

                switch (command)
                {
                    case "left up":
                        if ((col - 2) >= 0 && (row - 1) >= 0)
                        {
                            row -= 1;
                            col -= 2;

                            if (board[row, col] == 0)
                            {
                                board[row, col] = 1;
                            }
                            else if (board[row, col] == 1)
                            {
                                board[row, col] = 0;
                            }
                        }
                        break;
                    case "left down":
                        if ((col - 2) >= 0 && (row + 1) <= 7)
                        {
                            row += 1;
                            col -= 2;

                            if (board[row, col] == 0)
                            {
                                board[row, col] = 1;
                            }
                            else if (board[row, col] == 1)
                            {
                                board[row, col] = 0;
                            }
                        }
                        break;
                    case "right up":
                        if ((col + 2) <= 7 && (row - 1) >= 0)
                        {
                            row -= 1;
                            col += 2;

                            if (board[row, col] == 0)
                            {
                                board[row, col] = 1;
                            }
                            else if (board[row, col] == 1)
                            {
                                board[row, col] = 0;
                            }
                        }
                        break;
                    case "right down":
                        if ((col + 2) <= 7 && (row + 1) <= 7)
                        {
                            row += 1;
                            col += 2;

                            if (board[row, col] == 0)
                            {
                                board[row, col] = 1;
                            }
                            else if (board[row, col] == 1)
                            {
                                board[row, col] = 0;
                            }
                        }
                        break;
                    case "up left":
                        if ((col - 1) >= 0 && (row - 2) >= 0)
                        {
                            row -= 2;
                            col -= 1;

                            if (board[row, col] == 0)
                            {
                                board[row, col] = 1;
                            }
                            else if (board[row, col] == 1)
                            {
                                board[row, col] = 0;
                            }
                        }
                        break;
                    case "up right":
                        if ((col + 2) <= 7 && (row - 2) >= 0)
                        {
                            row -= 2;
                            col += 1;

                            if (board[row, col] == 0)
                            {
                                board[row, col] = 1;
                            }
                            else if (board[row, col] == 1)
                            {
                                board[row, col] = 0;
                            }
                        }
                        break;
                    case "down left":
                        if ((col - 1) >= 0 && (row + 2) <= 7)
                        {
                            row += 2;
                            col -= 1;

                            if (board[row, col] == 0)
                            {
                                board[row, col] = 1;
                            }
                            else if (board[row, col] == 1)
                            {
                                board[row, col] = 0;
                            }
                        }
                        break;
                    case "down right":
                        if ((col + 1) <= 7 && (row + 2) <= 7)
                        {
                            row += 2;
                            col += 1;

                            if (board[row, col] == 0)
                            {
                                board[row, col] = 1;
                            }
                            else if (board[row, col] == 1)
                            {
                                board[row, col] = 0;
                            }
                        }

                        break;
                }
            }

            string numberAsString = string.Empty;
            bool zeroDifferentNumber = false;
            for (int i = 0; i < board.GetLength(0); i++)
            {
                numberAsString = string.Empty;

                for (int j = 0; j < board.GetLength(1); j++)
                {
                    numberAsString += board[i, j];
                }

                int number = Convert.ToInt32(numberAsString, 2);
                if (number != 0)
                {
                    zeroDifferentNumber = true;
                    Console.WriteLine(number);
                }
            }

            if (zeroDifferentNumber == false)
            {
                Console.WriteLine("[Board is empty]");
            }
        }
    }
}
