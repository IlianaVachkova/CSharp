using System;

public static class CompareReverseSorted
{
    const int LOOP_END = 10000;
    const int ARRAY_SIZE = 100;
    static Random rand = new Random();
    static int[] arr = new int[ARRAY_SIZE];

    private static void FillArrayWithRandomValues()
    {
        for (int i = 0; i < ARRAY_SIZE; i++)
        {
            arr[i] = rand.Next(int.MinValue, int.MaxValue);
        }
    }

    public static void QuickSort()
    {
        Console.Write("Reverse Sorted, Quick Sort:\t");
        Display.ExecutionTime(() =>
        {
            FillArrayWithRandomValues();
            Array.Sort(arr);
            Array.Reverse(arr);
            for (int i = 0; i < LOOP_END; i++)
            {
                Array.Reverse(arr);
                SortUtil.QuickSort(arr, 0, arr.Length - 1);
            }
        });
    }

    public static void SelectionSort()
    {
        Console.Write("Reverse Sorted, Selection Sort:\t");
        Display.ExecutionTime(() =>
        {
            FillArrayWithRandomValues();
            Array.Sort(arr);
            Array.Reverse(arr);
            for (int i = 0; i < LOOP_END; i++)
            {
                Array.Reverse(arr);
                SortUtil.SelectionSort(arr);
            }
        });
    }

    public static void InsertionSort()
    {
        Console.Write("Reverse Sorted, Insertion Sort:\t");
        Display.ExecutionTime(() =>
        {
            FillArrayWithRandomValues();
            Array.Sort(arr);
            Array.Reverse(arr);
            for (int i = 0; i < LOOP_END; i++)
            {
                Array.Reverse(arr);
                SortUtil.InsertSort(arr);
            }
        });
    }
}