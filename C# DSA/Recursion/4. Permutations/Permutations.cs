using System;

public class Permutations
{
    public static void Main()
    {
        int start = 1;
        int n = 3;
        int[] arr = new int[n];
        bool[] used = new bool[n];
        Permutate(arr, used, start, 0);
    }

    public static void Permutate(int[] arr, bool[] used, int start, int index)
    {
        if (index >= arr.Length)
        {
            Console.WriteLine(string.Join(" ", arr));
            //Console.WriteLine(string.Join(" ", arr));
            return;
        }
        else
        {
            for (int i = start; i <= arr.Length; i++)
            {
                if (!used[i - start])
                {
                    arr[index] = i;
                    used[i - start] = true;
                    Permutate(arr, used, start, index + 1);
                    used[i - start] = false;
                }
            }
        }
    }
}