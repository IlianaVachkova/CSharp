using System;

public class NestedLoopsSimulation
{
    public static void Main()
    {
        int n = 3;
        int[] arr = new int[n];
        SimulateLoop(arr, 0);        
    }

    public static void SimulateLoop(int[] arr, int index)
    {
        if (index == arr.Length)
        {
            Console.WriteLine(string.Join(" ", arr));
            return;
        }
        else
        {
            for (int digit = 1; digit <= arr.Length; digit++)
            {
                arr[index] = digit;
                SimulateLoop(arr, index + 1);
            }
        }
    }
}