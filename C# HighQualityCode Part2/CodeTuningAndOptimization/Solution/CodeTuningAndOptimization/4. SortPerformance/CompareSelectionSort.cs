using System;

public static class CompareSelectionSort
{
    public const int LOOP_END = 10000;

    public static void Int()
    {
        Console.Write("Values-Int, Selection Sort:\t");
        Display.ExecutionTime(() =>
        {
            for (int i = 0; i < LOOP_END; i++)
            {
                var arr = new int[] { 3, 2, 4, 5, 1, 8, 9, 3, 2, 4 };
                SortUtil.SelectionSort(arr);
            }
        });
    }

    public static void Double()
    {
        Console.Write("Values-Double, Selection Sort:\t");
        Display.ExecutionTime(() =>
        {
            for (int i = 0; i < LOOP_END; i++)
            {
                var arr = new double[] { 3.4, 2.4, 4.3, 5.1, 1.3, 8.7, 9.4, 3.34, 2.23, 4.345 };
                SortUtil.SelectionSort(arr);
            }
        });
    }

    public static void String()
    {
        Console.Write("Values-String, Selection Sort:\t");
        Display.ExecutionTime(() =>
        {
            for (int i = 0; i < LOOP_END; i++)
            {
                var arr = new string[]
                {
                    "Avangard", "Display", "Avangarden", "Kilata",
                    "Beat", "Onyx", "Wutang", "Zero", "One", "Two"
                };
                SortUtil.SelectionSort(arr);
            }
        });
    }
}