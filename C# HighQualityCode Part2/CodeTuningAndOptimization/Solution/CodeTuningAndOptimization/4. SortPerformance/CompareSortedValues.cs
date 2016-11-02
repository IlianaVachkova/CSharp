using System;

public static class CompareSortedValues
{
    const int LOOP_END = 10000;
    const int ARRAY_SIZE = 100;
    static Random rand = new Random();
    static int[] arr = new int[ARRAY_SIZE];

    private static void InitializeSortedArray()
    {
        for (int i = 0; i < ARRAY_SIZE; i++)
        {
            arr[i] = rand.Next(int.MinValue, int.MaxValue);
        }
        Array.Sort(arr);
    }

    public static void QuickSort()
    {
        Console.Write("Sorted Values, Quick Sort:\t");
        Display.ExecutionTime(() =>
        {
            for (int i = 0; i < LOOP_END; i++)
            {
                SortUtil.QuickSort(arr, 0, arr.Length - 1);
            }
        });
    }

    public static void SelectionSort()
    {
        Console.Write("Sorted Values, Selection Sort:\t");
        Display.ExecutionTime(() =>
        {
            for (int i = 0; i < LOOP_END; i++)
            {
                SortUtil.SelectionSort(arr);
            }
        });
    }

    public static void InsertionSort()
    {
        Console.Write("Sorted Values, Insertion Sort:\t");
        Display.ExecutionTime(() =>
        {
            for (int i = 0; i < LOOP_END; i++)
            {
                SortUtil.InsertSort(arr);
            }
        });
    }
}