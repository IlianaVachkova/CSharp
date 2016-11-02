using System;

public static class SortUtil
{
    public static void InsertSort<T>(T[] arr) where T : IComparable<T>
    {
        for (int i = 1; i < arr.Length; i++)
        {
            T value = arr[i];
            int j = i - 1;
            while ((j >= 0) && (arr[j].CompareTo(value) > 0))
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = value;
        }
    }

    public static void SelectionSort<T>(T[] arr) where T : IComparable
    {
        for (int sortedSize = 0; sortedSize < arr.Length; sortedSize++)
        {
            int minElementIndex = sortedSize;
            T minElementValue = arr[sortedSize];
            for (int i = sortedSize + 1; i < arr.Length; i++)
            {
                if (arr[i].CompareTo(minElementValue) < 0)
                {
                    minElementIndex = i;
                    minElementValue = arr[i];
                }
            }
            arr[minElementIndex] = arr[sortedSize];
            arr[sortedSize] = minElementValue;
        }
    }

    public static void QuickSort<T>(T[] arr, int left, int right) where T : IComparable
    {
        int leftHold = left;
        int rightHold = right;
        Random rand = new Random();
        int pivot = rand.Next(left, right);
        Swap(arr, pivot, left);
        pivot = left;
        left++;

        while (right >= left)
        {
            if (arr[left].CompareTo(arr[pivot]) >= 0 && arr[right].CompareTo(arr[pivot]) < 0)
            {
                Swap(arr, left, right);
            }
            else if (arr[left].CompareTo(arr[pivot]) >= 0)
            {
                right--;
            }
            else if (arr[right].CompareTo(arr[pivot]) < 0)
            {
                left++;
            }
            else
            {
                right--;
                left++;
            }
        }

        Swap(arr, pivot, right);
        pivot = right;
        if (pivot > leftHold)
        {
            QuickSort(arr, leftHold, pivot);
        }
        if (rightHold > pivot + 1)
        {
            QuickSort(arr, pivot + 1, rightHold);
        }
    }

    private static void Swap<T>(T[] arr, int left, int right) where T : IComparable
    {
        T temp = arr[right];
        arr[right] = arr[left];
        arr[left] = temp;
    }
}