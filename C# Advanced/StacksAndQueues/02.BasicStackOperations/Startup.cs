/*
    Play around with a stack. You will be given an integer N representing the amount of elements 
    to push onto the stack, an integer S representing the amount of elements to pop from the stack 
    and finally an integer X, an element that you should check whether is present in the stack. 
    If it is print true on the console, if it’s not print the smallest element currently present in the stack.

    Input Format: On the first line you will be given N, S and X separated by a single space. 
    On the next line you will be given N amount of integers.

    Output Format: On a single line print either true if X is present in the stack otherwise 
    print smallest element in the stack. If the stack is empty print 0.

    Input:	        Output:	    Comments:
    5 2 13          true        We have to push 5 elements. Then we pop 2 of them. 
    1 13 45 32 4                Finally, we have to check whether 13 is present in 
                                the stack. Since it is we print true.
    	
    4 1 666         13
    420 69 13 666		
    
    3 3 90          0
    90 90 90	    	
    
*/

using System;
using System.Collections.Generic;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        int[] firstLine = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x)).ToArray();

        int numsToPush = firstLine[0];
        int numsToPop = firstLine[1];
        int numToContains = firstLine[2];
        int currentNum = 0;

        Stack<int> numsInStack = new Stack<int>();

        string[] arrOfNumToPush = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < arrOfNumToPush.Length; i++)
        {
            currentNum= int.Parse(arrOfNumToPush[i]);
            numsInStack.Push(currentNum);
        }

        for (int i = 0; i < numsToPop; i++)
        {
            numsInStack.Pop();
        }

        if (numsInStack.Count==0)
        {
            Console.WriteLine(0);
        }
        else if (numsInStack.Contains(numToContains))
        {
            Console.WriteLine("true");
        }
        else
        {
            int[] numsInStackAsArr = numsInStack.ToArray();
            Console.WriteLine(numsInStackAsArr.Min());
        }
    }
}

