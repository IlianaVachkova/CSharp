using System;

public class NonDuplicatedCombinations
{
    public static void Main()
    {
        int startNumber = 1;
        int endNumber = 5;
        int n = 3;
        int[] arr = new int[n];
        Combinate(arr, startNumber, endNumber, 0);
    }

    public static void Combinate(int[] arr, int startNumber, int endNumber, int index)
    {
        if (index == arr.Length)
        {
            Console.WriteLine(string.Join(" ", arr));
            return;
        }
        else
        {
            for (int i = startNumber; i <= endNumber; i++)
            {
                arr[index] = i;
                Combinate(arr, i + 1, endNumber, index + 1);
            }
        }
    }
}