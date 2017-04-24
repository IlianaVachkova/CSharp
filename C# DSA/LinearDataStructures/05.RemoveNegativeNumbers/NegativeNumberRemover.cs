using System;
using System.Collections.Generic;
using System.Linq;

public class NegativeNumberRemover
{
    public static void Main()
    {
        var arr = new int[] { 1, 2, -3, 4, -5, 6, 33, 2, -1, 7, -4, 3 };
        var resultSequence = RemoveNegativeNumbers(arr);
        Console.WriteLine(string.Join(" ", arr));
        Console.WriteLine(string.Join(" ", resultSequence));
    }

    public static List<int> RemoveNegativeNumbers(int[] arr)
    {
        var resultSequence = new List<int>();

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] >= 0)
            {
                resultSequence.Add(arr[i]);
            }
        }

        return resultSequence;
    }
}
