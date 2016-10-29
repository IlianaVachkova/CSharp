using System;

namespace PaintBall
{
    public class Startup
    {
        public static void Main()
        {
            int[,] board = new int[10, 10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    board[i, j] = 1;
                }
            }

            bool blackPaintShot = true;
            while (true)
            {
                string shot = Console.ReadLine();

                if (shot == "End")
                {
                    break;
                }

                string[] shotAsArr = shot.Split(' ');
                int row = int.Parse(shotAsArr[0]);
                int col = 9 - int.Parse(shotAsArr[1]);
                int radius = int.Parse(shotAsArr[2]);

                int startRow, endRow, startCol, endCol;

                if (row - radius < 0)
                {
                    startRow = 0;
                }
                else
                {
                    startRow = row - radius;
                }

                if (row + radius > 9)
                {
                    endRow = 9;
                }
                else
                {
                    endRow = row + radius;
                }

                if (col - radius < 0)
                {
                    startCol = 0;
                }
                else
                {
                    startCol = col - radius;
                }

                if (col + radius > 9)
                {
                    endCol = 9;
                }
                else
                {
                    endCol = col + radius;
                }

                for (int rowShot = startRow; rowShot <= endRow; rowShot++)
                {
                    for (int colShot = startCol; colShot <= endCol; colShot++)
                    {
                        if (blackPaintShot)
                        {
                            board[rowShot, colShot] = 0;
                        }
                        else if (!blackPaintShot)
                        {
                            board[rowShot, colShot] = 1;
                        }
                    }
                }

                if (blackPaintShot)
                {
                    blackPaintShot = false;
                }
                else
                {
                    blackPaintShot = true;
                }
            }

            string resultAsString = string.Empty;
            int sum = 0;
            int resultAsNumber = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    resultAsString += board[i, j];
                }

                resultAsNumber = Convert.ToInt32(resultAsString, 2);
                sum += resultAsNumber;
                resultAsString = string.Empty;
            }

            Console.WriteLine(sum);
        }
    }
}