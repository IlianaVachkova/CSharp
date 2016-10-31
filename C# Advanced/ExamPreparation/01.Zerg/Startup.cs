using System;

public class Startup
{
    public static void Main()
    {
        string input = Console.ReadLine();

        string digitAsStr = string.Empty;
        long result = 0;
        int step = 0;
        for (int i = input.Length - 1; i >= 0; i -= 4)
        {
            digitAsStr = input.Substring(i - 3, 4);

            switch (digitAsStr)
            {
                case "Rawr": result += 0 * (long)Math.Pow(15, step); break;
                case "Rrrr": result += 1 * (long)Math.Pow(15, step); break;
                case "Hsst": result += 2 * (long)Math.Pow(15, step); break;
                case "Ssst": result += 3 * (long)Math.Pow(15, step); break;
                case "Grrr": result += 4 * (long)Math.Pow(15, step); break;
                case "Rarr": result += 5 * (long)Math.Pow(15, step); break;
                case "Mrrr": result += 6 * (long)Math.Pow(15, step); break;
                case "Psst": result += 7 * (long)Math.Pow(15, step); break;
                case "Uaah": result += 8 * (long)Math.Pow(15, step); break;
                case "Uaha": result += 9 * (long)Math.Pow(15, step); break;
                case "Zzzz": result += 10 * (long)Math.Pow(15, step); break;
                case "Bauu": result += 11 * (long)Math.Pow(15, step); break;
                case "Djav": result += 12 * (long)Math.Pow(15, step); break;
                case "Myau": result += 13 * (long)Math.Pow(15, step); break;
                case "Gruh": result += 14 * (long)Math.Pow(15, step); break;
            }

            step++;
        }

        Console.WriteLine(result);
    }
}
