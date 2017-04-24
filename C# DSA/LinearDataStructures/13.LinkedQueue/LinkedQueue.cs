using System;
using System.Text;

public class LinkedQueue<T>
{
    public QueueItem<T> First { get; set; }
    public QueueItem<T> Last { get; set; }
    public int Count { get; set; }

    public LinkedQueue()
    {
        this.Count = 1;
    }

    public void Enqueue(T value)
    {
        if (this.First == null)
        {
            this.First = new QueueItem<T>(value);
            this.Last = this.First;
            this.Count = 1;
        }
        else
        {
            this.Last = new QueueItem<T>(value, this.Last);
            this.Count++;
        }
    }

    public T Dequeue()
    {
        var dequeuedValue = this.First.Value;
        this.First = this.First.Next;
        this.Count--;

        return dequeuedValue;
    }

    public T Peek()
    {
        return this.First.Value;
    }

    public override string ToString()
    {
        var result = new StringBuilder();
        var current = this.First;
        while (current != null)
        {
            result.AppendFormat("{0} ", current.Value);
            current = current.Next;
        }

        return result.ToString().TrimEnd();
    }
}