using System;

public class Variations
{
    public static void Main()
    {
        int k = 2;
        string[] words = { "hi", "a", "b" };
        string[] result = new string[k];

        Variate(words, result, 0);
    }

    public static void Variate(string[] words, string[] result, int index)
    {
        if (index >= result.Length)
        {
            Console.WriteLine(string.Join(", ", result));
        }
        else
        {
            for (int i = 0; i < words.Length; i++)
            {
                result[index] = words[i];
                Variate(words, result, index + 1);
            }
        }
    }
}