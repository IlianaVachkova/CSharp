using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Startup
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        var input = "свиквайдатисеслучваоттукнататък:)";

        string[] words = { "да", "свиквай", "случва", "ти", "се", "оттук", "нататък", ":)" };

        var sorted = words.Distinct().OrderByDescending(x => x.Length).ToList();

        var sentence = new List<string>();

        var start = 0;
        var index = 0;
        while (start < input.Count())
        {

            for (int i = 0; i < sorted.Count(); i++)
            {
                index = input.IndexOf(sorted[i], start);
                if (index == start)
                {
                    sentence.Add(sorted[i]);
                    start = index + sorted[i].Length;
                    break;
                }
            }

            if (index > start)
            {
                start++;
            }

            if (index >= input.Count())
            {
                break;
            }
        }

        Console.WriteLine(string.Join(" ", sentence));
    }
}