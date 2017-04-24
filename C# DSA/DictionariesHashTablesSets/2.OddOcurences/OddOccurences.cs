using System;
using System.Collections.Generic;

public class OddOccurences
{
    public static void Main()
    {
        string[] words = new string[] { "C#", "SQL", "PHP", "PHP", "SQL", "SQL" };
        Dictionary<string, int> occurences = new Dictionary<string, int>();

        foreach (var word in words)
        {
            if (occurences.ContainsKey(word))
            {
                occurences[word]++;
            }
            else
            {
                occurences.Add(word, 1);
            }
        }

        Console.WriteLine("Words: {0}", string.Join(" ", words));

        foreach (var word in occurences)
        {
            if (word.Value % 2 != 0)
            {
                Console.Write(word.Key + " ");
            }
        }

        Console.WriteLine();
    }
}