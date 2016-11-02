using System;

class SortPerformance
{
    static void Main()
    {
        var arr = new int[] { 3, 2, 4, 5, 1, 8, 9, 3, 2, 4 };
        SortUtil.QuickSort(arr, 0, arr.Length - 1);
        Console.WriteLine("After Quick Sort: {0}", string.Join(", ", arr));

        arr = new int[] { 3, 2, 4, 5, 1, 8, 9, 3, 2, 4 };
        SortUtil.InsertSort(arr);
        Console.WriteLine("After Insert Sort: {0}", string.Join(", ", arr));

        arr = new int[] { 3, 2, 4, 5, 1, 8, 9, 3, 2, 4 };
        SortUtil.SelectionSort(arr);
        Console.WriteLine("After Selection Sort: {0}", string.Join(", ", arr));

        Console.WriteLine("-----------------------------");

        CompareQuickSort.Int();
        CompareQuickSort.Double();
        CompareQuickSort.String();

        Console.WriteLine("-----------------------------");

        CompareSelectionSort.Int();
        CompareSelectionSort.Double();
        CompareSelectionSort.String();

        Console.WriteLine("-----------------------------");

        CompareInsertionSort.Int();
        CompareInsertionSort.Double();
        CompareInsertionSort.String();

        Console.WriteLine("-----------------------------");

        CompareRandomValues.QuickSort();
        CompareRandomValues.InsertionSort();
        CompareRandomValues.SelectionSort();

        Console.WriteLine("-----------------------------");

        CompareReverseSorted.QuickSort();
        CompareReverseSorted.InsertionSort();
        CompareReverseSorted.SelectionSort();

        Console.WriteLine("-----------------------------");

        CompareSortedValues.QuickSort();
        CompareSortedValues.InsertionSort();
        CompareSortedValues.SelectionSort();
    }
}