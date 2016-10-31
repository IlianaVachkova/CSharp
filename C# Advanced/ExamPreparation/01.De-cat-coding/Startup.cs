using System;
using System.Numerics;

public class Startup
{
    public static void Main()
    {
        string[] words = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        BigInteger currentSum = 0;
        int step = 0;
        for (int i = 0; i < words.Length; i++)
        {
            step = 0;
            for (int j = words[i].Length - 1; j >= 0; j--)
            {
                currentSum += ((words[i][j] - 'a') * (BigInteger)Math.Pow(21, step));
                step++;
            }

            string result = string.Empty;
            while (currentSum != 0)
            {
                BigInteger reminder = (currentSum % 26);
                result = (char)(reminder + 97) + result;
                currentSum /= 26;
            }

            Console.Write(result + " ");

            result = string.Empty;

            currentSum = 0;
        }
    }
}

