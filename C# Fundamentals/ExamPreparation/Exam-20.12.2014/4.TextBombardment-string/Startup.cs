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
            char[] textAsCharArr = new char[text.Length];
            textAsCharArr = text.ToCharArray();

            for (int i = 0; i < columnsAsArr.Length; i++)
            {
                columnsNumbers[i] = int.Parse(columnsAsArr[i]);
            }

            bool isColumnBombed = false;
            for (int i = 0; i < textAsCharArr.Length; i++)
            {
                for (int j = 0; j < columnsNumbers.Length; j++)
                {
                    if (i % width == columnsNumbers[j] && textAsCharArr[i] == ' ' && isColumnBombed)
                    {
                        columnsNumbers[j] = -1;
                        break;
                    }
                    else if (i % width == columnsNumbers[j])
                    {
                        isColumnBombed = true;
                        textAsCharArr[i] = ' ';
                    }
                }
                isColumnBombed = false;
            }

            string resultText = string.Empty;
            for (int i = 0; i < textAsCharArr.Length; i++)
            {
                resultText += textAsCharArr[i];
            }

            Console.WriteLine(resultText);
        }
    }
}
