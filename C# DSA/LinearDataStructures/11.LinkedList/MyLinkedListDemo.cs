using System;

public class MyLinkedListDemo
{
    public static void Main()
    {
        var linkedList = new MyLinkedList<int>(2);
        //list = new MyLinkedList<int>();
        linkedList.Add(1);
        linkedList.Add(23);
        linkedList.Add(234);
        linkedList.Add(0);
        linkedList.Add(-23);
        linkedList.Remove(5);
        Console.WriteLine(linkedList);
    }
}