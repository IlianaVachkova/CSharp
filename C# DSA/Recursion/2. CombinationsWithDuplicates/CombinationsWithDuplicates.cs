using System;

public class CombinationsWithDuplicates
{
    public static void Main()
    {
        int count = 3;
        int n = 2;
        int[] arr = new int[n];
        DuplicatedCombinations(arr, count, 0);
    }

    public static void DuplicatedCombinations(int[] arr, int count, int index)
    {
        if (index == arr.Length)
        {
            Console.WriteLine(string.Join(" ", arr));
            return;
        }
        else
        {
            for (int i = 1; i <= count; i++)
            {
                arr[index] = i;
                DuplicatedCombinations(arr, count, index + 1);
            }
        }
    }
}