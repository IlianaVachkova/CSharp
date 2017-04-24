using System;
using System.IO;
using System.Collections.Generic;

public class CountWordsInFile
{
    public static void Main()
    {
        StreamReader reader = new StreamReader("..//..//words.txt");

        string text = reader.ReadToEnd();
        string[] words = text.Split(new char[] { ' ', '.', ',', '?', '!', '-' },
            StringSplitOptions.RemoveEmptyEntries);
        Dictionary<string, int> occurences = new Dictionary<string, int>();

        foreach (var word in words)
        {
            var lowerWord = word.ToLower();
            if (occurences.ContainsKey(lowerWord))
            {
                occurences[lowerWord]++;
            }
            else
            {
                if (char.IsLetterOrDigit(word[0]))
                {
                    occurences.Add(lowerWord, 1);
                }
            }
        }

        foreach (var word in occurences)
        {
            Console.WriteLine("{0} -> {1} times.", word.Key, word.Value);
        }

        reader.Close();
    }
}