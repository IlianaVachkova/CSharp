using System;

public class Startup
{
    public static void Main()
    {
        string input = Console.ReadLine();
        string digitsAsStr = string.Empty;

        for (int i = 0; i < input.Length; i++)
        {
            switch (input[i])
            {
                case 'f': digitsAsStr = '0' + digitsAsStr; break;
                case 'b': digitsAsStr = '1' + digitsAsStr; i += 2; break;
                case 'o': digitsAsStr = '2' + digitsAsStr; i += 4; break;
                case 'm': digitsAsStr = '3' + digitsAsStr; i += 6; break;
                case 'l': digitsAsStr = '4' + digitsAsStr; i += 5; break;
                case 'p': digitsAsStr = '5' + digitsAsStr; i += 3; break;
                case 'h': digitsAsStr = '6' + digitsAsStr; i += 1; break;
            }
        }

        long result = 0;
        for (int i = 0; i < digitsAsStr.Length; i++)
        {
            result += ((digitsAsStr[i] - '0') * (long)Math.Pow(7, i));
        }

        Console.WriteLine(result);
    }
}

