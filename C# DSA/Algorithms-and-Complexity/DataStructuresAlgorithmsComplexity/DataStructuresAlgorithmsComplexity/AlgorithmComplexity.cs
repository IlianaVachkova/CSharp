using System;

public class AlgorithmComplexity
{
    public static void Main()
    {
        // Task 1 Example
        int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };
        long result = Compute(arr);
        Console.WriteLine("Task 1 result - {0}", result);

        // Task 2 Example
        int[,] matrix = new int[,]
        {
            {1, 2, 3, 4},
            {1, 2, 3, 4},
            {1, 2, 3, 4},
        };
        result = CalcCount(matrix);
        Console.WriteLine("Task 2 result - {0}", result);

        // Task 3 Example
        result = CalcSum(matrix, 0);
        Console.WriteLine("Task 3 result - {0}", result);
    }

    //Task1
    public static long Compute(int[] arr)
    {
        long count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            int start = 0;
            int end = arr.Length - 1;
            while (start < end)
            {
                if (arr[start] < arr[end])
                {
                    start++;
                    count++;
                }
                else
                {
                    end--;
                }
            }
        }

        return count;
    }

    //Task2
    public static long CalcCount(int[,] matrix)
    {
        long count = 0;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            if (matrix[row, 0] % 2 == 0)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] > 0)
                    {
                        count++;
                    }
                }
            }
        }

        return count;
    }

    //Task3
    public static long CalcSum(int[,] matrix, int row)
    {
        long sum = 0;
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            sum += matrix[row, col];
        }
        if (row + 1 < matrix.GetLength(0))
        {
            sum += CalcSum(matrix, row + 1);
        }

        return sum;
    }
}