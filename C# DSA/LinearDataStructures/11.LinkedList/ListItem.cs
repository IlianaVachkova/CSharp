using System;

public class ListItem<T>
{
    public T Value { get; set; }

    public ListItem<T> Next { get; set; }

    public ListItem(T value)
    {
        this.Value = value;
    }

    public ListItem(T value, ListItem<T> previous)
        : this(value)
    {
        previous.Next = this;
    }
}
