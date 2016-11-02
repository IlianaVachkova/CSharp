using System;

public static class CompareRandomValues
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
        Console.Write("Random Values, Quick Sort:\t");
        Display.ExecutionTime(() =>
        {
            for (int i = 0; i < LOOP_END; i++)
            {
                FillArrayWithRandomValues();
                SortUtil.QuickSort(arr, 0, arr.Length - 1);
            }
        });
    }

    public static void SelectionSort()
    {
        Console.Write("Random Values, Selection Sort:\t");
        Display.ExecutionTime(() =>
        {
            for (int i = 0; i < LOOP_END; i++)
            {
                FillArrayWithRandomValues();
                SortUtil.SelectionSort(arr);
            }
        });
    }

    public static void InsertionSort()
    {
        Console.Write("Random Values, Insertion Sort:\t");
        Display.ExecutionTime(() =>
        {
            for (int i = 0; i < LOOP_END; i++)
            {
                FillArrayWithRandomValues();
                SortUtil.InsertSort(arr);
            }
        });
    }
}