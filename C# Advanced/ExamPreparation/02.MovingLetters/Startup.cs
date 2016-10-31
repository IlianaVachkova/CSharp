using System;

public class Startup
{
    public static void Main()
    {
        string[] words = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int wholeLen = 0;
        for (int i = 0; i < words.Length; i++)
        {
            wholeLen += words[i].Length;
        }

        char[] extractedLetters = new char[wholeLen];

        int pos = 1;
        int posInArr = 0;
        while (wholeLen != posInArr)
        {
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length - pos >= 0)
                {
                    extractedLetters[posInArr] = (words[i][words[i].Length - pos]);
                    posInArr++;
                }
            }

            pos++;
        }

        int newPos = 0;
        char letterToMove = '@';
        for (int i = 0; i < extractedLetters.Length; i++)
        {
            if (extractedLetters[i] >= 65 && extractedLetters[i] <= 90)
            {
                newPos = ((extractedLetters[i] - '@') + i) % extractedLetters.Length;
            }
            else if (extractedLetters[i] >= 97 && extractedLetters[i] <= 122)
            {
                newPos = ((extractedLetters[i] - '`') + i) % extractedLetters.Length;
            }

            letterToMove = extractedLetters[i];

            if (i < newPos)
            {
                for (int j = i; j < newPos; j++)
                {
                    extractedLetters[j] = extractedLetters[j + 1];
                }
            }
            else if (i > newPos)
            {
                for (int j = i; j > newPos; j--)
                {
                    extractedLetters[j] = extractedLetters[j - 1];
                }
            }

            extractedLetters[newPos] = letterToMove;
        }

        Console.WriteLine(String.Join("", extractedLetters));
    }
}

