using System;

public class PermutationsWithRepetitions
{
    public static void Main()
    {
        int[] arr = { 1, 3, 5, 5 };
        Array.Sort(arr);
        Permutate(arr, 0, arr.Length);
    }

    public static void Permutate(int[] arr, int start, int end)
    {
        // print the array
        Console.WriteLine(string.Join(" ", arr));

        for (int left = end - 2; left >= start; left--)
        {
            for (int right = left + 1; right < end; right++)
            {
                if (arr[left] != arr[right])
                {
                    Swap(ref arr[left], ref arr[right]);
                    Permutate(arr, left + 1, end);
                }
            }

            // Undo all modifications done up to here
            var firstElement = arr[left];
            for (int i = left; i < end - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            arr[end - 1] = firstElement;
        }
    }

    public static void Swap(ref int first, ref int second)
    {
        int temp = first;
        first = second;
        second = temp;
    }
}