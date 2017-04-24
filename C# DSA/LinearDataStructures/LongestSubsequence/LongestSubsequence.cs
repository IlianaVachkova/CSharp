using System;
using System.Collections.Generic;
using System.Linq;

public class LongestSubsequence
{
    public static void Main()
    {
        List<int> sequence = new List<int>() { 1, 2, 3, 4, 5, 3, 4, 4, 3, 3, 2, 2, 2, 2, 1 };
        List<int> longestSubsequence = GetLongestSubsequence(sequence);

        Console.WriteLine("Sequence {0}:", string.Join(" ", sequence));
        Console.WriteLine("Longest subsequence {0}:", string.Join(" ", longestSubsequence));
    }

    public static List<int> GetLongestSubsequence(List<int> sequence)
    {
        if (sequence == null)
        {
            throw new ArgumentNullException("The sequence cannot be null!");
        }

        if (sequence.Count == 1)
        {
            return sequence;
        }

        int count = 1;
        int maxCount = 0;
        int mostFreqElement = int.MinValue;
        for (int i = 0; i < sequence.Count - 1; i++)
        {
            if (sequence[i] == sequence[i + 1])
            {
                count++;
                if (count > maxCount)
                {
                    maxCount = count;
                    mostFreqElement = sequence[i];
                }
            }
            else
            {
                count = 1;
            }
        }

        List<int> resultSequence = new List<int>();
        for (int i = 0; i < maxCount; i++)
        {
            resultSequence.Add(mostFreqElement);
        }

        return resultSequence;
    }
}
