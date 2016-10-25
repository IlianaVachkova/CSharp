/*
    Description:
    Write a method that adds two positive integer numbers represented as arrays of digits 
    (each array element arr[i] contains a digit; the last digit is kept in arr[0]). 
    Write a program that reads two arrays representing positive integers and outputs their sum.
    
    Input:
    On the first line you will receive two numbers separated by spaces - the size of each array
    On the second line you will receive the first array
    On the third line you will receive the second array
    
    Output:
    Print the sum as an array of digits (as described)
        Digits should be separated by spaces
*/

using System;

public class Startup
{
    public static void Main()
    {
        string[] sizes = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int firstArrSize = int.Parse(sizes[0]);
        int secondArrSize = int.Parse(sizes[1]);
        string[] firstArrAsStr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string[] secondArrAsStr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] firstArr = new int[firstArrSize];
        int[] secondArr = new int[secondArrSize];

        for (int i = 0; i < firstArrSize; i++)
        {
            firstArr[i] = int.Parse(firstArrAsStr[i]);
        }

        for (int i = 0; i < secondArrSize; i++)
        {
            secondArr[i] = int.Parse(secondArrAsStr[i]);
        }

        int[] resultArr = AddingTwoNumbers(firstArr, secondArr);

        for (int i = 0; i < resultArr.Length - 1; i++)
        {
            if (i != resultArr.Length - 2)
            {
                Console.Write(resultArr[i] + " ");
            }
            else
            {
                Console.Write(resultArr[i]);
            }
        }

        if (resultArr[resultArr.Length - 1] != -1)
        {
            Console.Write(" " + resultArr[resultArr.Length - 1]);
        }
    }

    public static int[] AddingTwoNumbers(int[] firstArr, int[] secondArr)
    {
        int minLen = Math.Min(firstArr.Length, secondArr.Length);
        int maxLen = Math.Max(firstArr.Length, secondArr.Length);
        int digitToAdd = 0;
        int[] resultArr = new int[maxLen + 1];
        resultArr[maxLen] = -1;

        for (int i = 0; i < minLen; i++)
        {
            resultArr[i] = (firstArr[i] + secondArr[i] + digitToAdd) % 10;
            digitToAdd = (firstArr[i] + secondArr[i] + digitToAdd) / 10;
        }

        if (firstArr.Length > secondArr.Length)
        {
            for (int i = minLen; i < maxLen; i++)
            {
                resultArr[i] = (firstArr[i] + digitToAdd) % 10;
                digitToAdd = (firstArr[i] + digitToAdd) / 10;
            }
        }
        else if (firstArr.Length < secondArr.Length)
        {
            for (int i = minLen; i < maxLen; i++)
            {
                resultArr[i] = (secondArr[i] + digitToAdd) % 10;
                digitToAdd = (secondArr[i] + digitToAdd) / 10;
            }
        }

        if (digitToAdd != 0)
        {
            resultArr[maxLen] = digitToAdd;
        }

        return resultArr;
    }
}
