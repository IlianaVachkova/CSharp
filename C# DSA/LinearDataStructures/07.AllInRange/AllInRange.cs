using System;
using System.Collections.Generic;
using System.Linq;

public class AllInRange
{
    public static void Main()
    {
        var arr = new int[] { 3, 4, 4, 2, 3, 3, 4, 3, 2 };
        var start = 0;
        var end = 1000;
        var resultDict = FindAllOccurences(arr);

        for (int number = start; number <= end; number++)
        {
            if (resultDict.ContainsKey(number))
            {
                Console.WriteLine("{0} -> {1} times", number, resultDict[number]);
            }
            else
            {
                //Console.WriteLine("{0} -> 0 times", number);
            }
        }
    }

    public static Dictionary<int, int> FindAllOccurences(int[] arr)
    {
        var resultDict = new Dictionary<int, int>();

        for (int i = 0; i < arr.Length; i++)
        {
            if (resultDict.ContainsKey(arr[i]))
            {
                resultDict[arr[i]]++;
            }
            else
            {
                resultDict.Add(arr[i], 1);
            }
        }

        return resultDict;
    }
}
