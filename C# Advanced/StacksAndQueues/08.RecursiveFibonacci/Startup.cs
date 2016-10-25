﻿/*
    The Fibonacci sequence is quite a famous sequence of numbers. Each member of the sequence is 
    calculated from the sum of the two previous elements. The first two elements are 1, 1. Therefore 
    the sequence goes as 1, 1, 2, 3, 5, 8, 13, 21, 34… 
    The following sequence can be generated with an array, but that’s easy, so your task is to 
    implement recursively.
    So if the function GetFibonacci(n) returns the n’th Fibonacci number we can express it using 
    GetFibonacci(n) = GetFibonacci(n-1) + GetFibonacci(n-2)
    However, this will never end and in a few seconds a StackOverflow Exception is thrown. In order 
    for the recursion to stop it has to have a “bottom”. The bottom of the recursion is GetFibonacci(1) 
    should return 1 and GetFibonacci(0) should return 0.

    Input Format: On the only line in the input the user should enter the wanted Fibonacci number.

    Output Format: The output should be the n’th Fibonacci number counting from 0 

    Constraints: 
    1 ≤ N ≤ 49
    Input:	Output:
    5	    5
    10	    55
    21	    10946
*/

using System;

public class Startup
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(GetFibonacci(n));
    }

    public static int GetFibonacci(int n)
    {
        int fibNum = 0;

        if (n==1)
        {
            return 1;
        }
        else if (n==0)
        {
            return 0;
        }

        fibNum = GetFibonacci(n-1) + GetFibonacci(n-2);

        return fibNum;
    }
}

