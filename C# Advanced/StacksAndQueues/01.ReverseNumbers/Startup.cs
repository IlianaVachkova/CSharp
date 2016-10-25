/*
    Write a program that reads N integers from the console and reverses them using a stack. 
    Use the Stack<int> class from .NET Framework. Just put the input numbers in the stack and pop them. 
    Examples:
        Input:	        Output:
        1 2 3 4 5	    5 4 3 2 1
        1	            1
*/

using System;
using System.Collections.Generic;

public class Startup
{
    public static void Main()
    {
        string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        Stack<int> numsInStack = new Stack<int>();

        for (int i = 0; i < input.Length; i++)
        {
            numsInStack.Push(int.Parse(input[i]));
        }

        while (numsInStack.Count>0)
        {
            Console.Write($"{numsInStack.Pop()} ");
        }
    }
}

