/*
    Play around with a queue. You will be given an integer N representing the amount of elements to 
    enqueue, an integer S representing the amount of elements to dequeue from the queue and finally 
    an integer X, an element that you should check whether is present in the queue. If it is print 
    true on the console, if it’s not print the smallest element currently present in the queue.

    Input:	        Output:	        Comments:
    5 2 32          true            We have to push 5 elements. Then we pop 2 of them. 
    1 13 45 32 4                    Finally, we have to check whether 13 is present in 
                                    the stack. Since it is we print true.
    	
    4 1 666         13
    666 69 13 420	
    	
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
        string[] firstLine = Console.ReadLine().Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries);
        int numsToEnqueue = int.Parse(firstLine[0]);
        int numsToDequeue = int.Parse(firstLine[1]);
        int numToContains = int.Parse(firstLine[2]);
        int currentNum = 0;

        Queue<int> numsInQueue = new Queue<int>();

        string[] arrOfNumToPush = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < arrOfNumToPush.Length; i++)
        {
            currentNum = int.Parse(arrOfNumToPush[i]);
            numsInQueue.Enqueue(currentNum);
        }

        for (int i = 0; i < numsToDequeue; i++)
        {
            numsInQueue.Dequeue();
        }

        if (numsInQueue.Count == 0)
        {
            Console.WriteLine(0);
        }
        else if (numsInQueue.Contains(numToContains))
        {
            Console.WriteLine("true");
        }
        else
        {
            int[] numsInQueueAsArr = numsInQueue.ToArray();
            Console.WriteLine(numsInQueueAsArr.Min());
        }
    }
}

