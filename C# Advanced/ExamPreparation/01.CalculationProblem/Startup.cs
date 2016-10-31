using System;

public class Startup
{
    public static void Main()
    {
        string[] words = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int sum = 0;
        int currentSum = 0;
        int step = 0;
        for (int i = 0; i < words.Length; i++)
        {
            step = 0;
            for (int j = words[i].Length - 1; j >= 0; j--)
            {
                currentSum += ((words[i][j] - 'a') * (int)Math.Pow(23, step));
                step++;
            }

            sum += currentSum;
            currentSum = 0;
        }

        string result = string.Empty;
        int sumToChange = sum;
        while (sumToChange != 0)
        {
            int reminder = (sumToChange % 23);
            result = (char)(reminder + 97) + result;
            sumToChange /= 23;
        }

        Console.WriteLine("{0} = {1}", result, sum);
    }
}

