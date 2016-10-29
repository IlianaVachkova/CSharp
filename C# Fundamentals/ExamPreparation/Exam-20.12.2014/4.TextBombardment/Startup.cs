using System;

namespace _4.TextBombardment
{
    public class Startup
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            int width = int.Parse(Console.ReadLine());
            string columns = Console.ReadLine();
            string[] columnsAsArr = columns.Split(' ');
            int[] columnsNumbers = new int[columnsAsArr.Length];

            for (int i = 0; i < columnsAsArr.Length; i++)
            {
                columnsNumbers[i] = int.Parse(columnsAsArr[i]);
            }

            int textLength = text.Length;
            int divPart = textLength / width;
            int modPart = textLength % width;

            int rows = 0;
            int cols = 0;
            if (modPart == 0)
            {
                rows = divPart;
                cols = width;
            }
            else if (modPart > 0)
            {
                rows = divPart + 1;
                cols = width;
            }

            char[,] inputText = new char[rows, cols];
            int textIndexNumber = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (textIndexNumber == textLength)
                    {
                        break;
                    }
                    else
                    {
                        inputText[i, j] = text[textIndexNumber];
                    }
                    textIndexNumber += 1;
                }
            }

            for (int k = 0; k < columnsNumbers.Length; k++)
            {
                for (int i = 0; i < cols; i++)
                {
                    bool isColumnBombed = false;
                    for (int j = 0; j < rows; j++)
                    {
                        if (i == columnsNumbers[k] && inputText[j, i] == ' ' && isColumnBombed)
                        {
                            break;
                        }
                        else if (i == columnsNumbers[k] && inputText[j, i] != ' ')
                        {
                            inputText[j, i] = ' ';
                            isColumnBombed = true;
                        }
                    }
                }
            }

            string bombedText = string.Empty;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    bombedText += inputText[i, j];
                }
            }

            Console.WriteLine(bombedText);
        }
    }
}
