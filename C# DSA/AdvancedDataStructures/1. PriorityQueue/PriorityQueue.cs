using System;

public class PriorityQueue<T> where T : IComparable<T>
{
    private BinaryHeap<T> elements;

    public PriorityQueue(int capacity)
    {
        this.elements = new BinaryHeap<T>(capacity);
    }

    public PriorityQueue()
    {
        this.elements = new BinaryHeap<T>();
    }

    public void Enqueue(T element)
    {
        this.elements.Add(element);
    }

    public T Dequeue()
    {
        return this.elements.Pop();
    }

    public T Peek()
    {
        return this.elements.Peek();
    }
}