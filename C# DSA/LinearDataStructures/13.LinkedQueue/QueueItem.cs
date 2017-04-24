using System;

public class QueueItem<T>
{
    public T Value { get; set; }
    public QueueItem<T> Next { get; set; }

    public QueueItem(T value)
    {
        this.Value = value;
    }

    public QueueItem(T value, QueueItem<T> previous)
        : this(value)
    {
        previous.Next = this;
    }
}