using System;

public class SubsetOfStrings
{
    public static void Main()
    {
        int k = 2;
        string[] words = { "test", "rock", "fun" };
        string[] result = new string[k];
        bool[] used = new bool[words.Length];

        GenerateSubset(words, result, used, 0, 0);
    }

    public static void GenerateSubset(string[] words, string[] result, bool[] used, 
        int index, int wordsStartIndex)
    {
        if (index >= result.Length)
        {
            Console.WriteLine(string.Join(", ", result));
            return;
        }
        else
        {
            for (int i = wordsStartIndex; i < words.Length; i++)
            {
                if (!used[i])
                {
                    result[index] = words[i];
                    used[i] = true;
                    GenerateSubset(words, result, used, index + 1, i + 1);
                    used[i] = false;
                }                
            }
        }
    }
}