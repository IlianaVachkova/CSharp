/*
    Description:
    Write a method that adds two polynomials. Represent them as arrays of their coefficients. 
    Write a program that reads two polynomials and prints their sum.
    
    Input:
    On the first line you will receive the number N
    On the second line you will receive the first polynomial as coefficients separated by spaces
    On the third line you will receive the second polynomial as coefficients separated by spaces
    
    Output:
    Print the sum of the polynomials
*/

using System;

public class Startup
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] firstArrAsStr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string[] secondArrAsStr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] firstArr = new int[n];
        int[] secondArr = new int[n];

        for (int i = 0; i < firstArr.Length; i++)
        {
            firstArr[i] = int.Parse(firstArrAsStr[i]);
        }

        for (int i = 0; i < secondArr.Length; i++)
        {
            secondArr[i] = int.Parse(secondArrAsStr[i]);
        }

        int[] resultArr = AddTwoPolinomials(firstArr, secondArr);

        Console.WriteLine(string.Join(" ", resultArr));
    }

    public static int[] AddTwoPolinomials(int[] firstArr, int[] secondArr)
    {
        int[] result = new int[firstArr.Length];

        for (int i = 0; i < result.Length; i++)
        {
            result[i] = firstArr[i] + secondArr[i];
        }

        return result;
    }
}

