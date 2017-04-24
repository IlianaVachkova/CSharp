using System;
using System.Collections.Generic;

public class NumberOccurences
{
    public static void Main()
    {
        double[] arr = new double[] { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };
        Dictionary<double, int> occurences = new Dictionary<double, int>();

        foreach (var number in arr)
        {
            if (occurences.ContainsKey(number))
            {
                occurences[number]++;
            }
            else
            {
                occurences.Add(number, 1);
            }
        }

        foreach (var number in occurences)
        {
            Console.WriteLine("{0} -> {1} times.", number.Key, number.Value);
        }
    }
}