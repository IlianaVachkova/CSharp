using System;

public class Program
{
    public static void Main()
    {
        PriorityQueue<int> pQueue = new PriorityQueue<int>();

        pQueue.Enqueue(50);
        pQueue.Enqueue(3);
        pQueue.Enqueue(1);
        pQueue.Enqueue(52);
        pQueue.Enqueue(64);
        pQueue.Enqueue(23);
        pQueue.Enqueue(35);
        pQueue.Enqueue(4);
        Console.WriteLine(pQueue.Dequeue());
        Console.WriteLine(pQueue.Dequeue());
        Console.WriteLine(pQueue.Dequeue());
        Console.WriteLine(pQueue.Dequeue());
        Console.WriteLine(pQueue.Dequeue());
        Console.WriteLine(pQueue.Dequeue());
        Console.WriteLine(pQueue.Dequeue());
        Console.WriteLine(pQueue.Dequeue());
    }
}