/*
    There is another way of calculating the Fibonacci sequence using a stack. It is non recursive, 
    so it does not make any unnecessary calculations. Try implementing it. First push 1 and 1 and 
    them use popping peeking and pushing to generate every consecutive number. 

    Input:	Output:
    7	    13
    15	    610
    33	    3524578
*/

using System;
using System.Collections.Generic;

public class Startup
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Stack<long> fibInStack = new Stack<long>();
        long firstNum = 0;
        long secondNum = 0;

        fibInStack.Push(1);
        fibInStack.Push(1);

        for (int i = 2; i < n; i++)
        {
            secondNum = fibInStack.Pop();
            firstNum = fibInStack.Peek();
            fibInStack.Push(secondNum);
            fibInStack.Push(firstNum + secondNum);
        }

        Console.WriteLine(fibInStack.Pop());
    }
}

