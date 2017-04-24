using System;
using System.Collections.Generic;
using System.Linq;

public class OddNumberOccurRemoval
{
    public static void Main()
    {
        var arr = new int[] { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };
        var resultSequence = RemoveOddNumberOccurences(arr);

        Console.WriteLine(string.Join(" ", arr));
        Console.WriteLine(string.Join(" ", resultSequence));
    }

    public static List<int> RemoveOddNumberOccurences(int[] arr)
    {
        var dictionary = new Dictionary<int, int>();

        for (int i = 0; i < arr.Length; i++)
        {
            if (!dictionary.ContainsKey(arr[i]))
            {
                dictionary.Add(arr[i], 1);
            }
            else
            {
                dictionary[arr[i]]++;
            }
        }

        var resultSequence = new List<int>();
        for (int i = 0; i < arr.Length; i++)
        {
            if (dictionary[arr[i]] % 2 == 0)
            {
                resultSequence.Add(arr[i]);
            }
        }

        return resultSequence;
    }
}
