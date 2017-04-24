using System;
using System.Text;

public class MyLinkedList<T>
{
    public ListItem<T> First { get; set; }
    public ListItem<T> Last { get; set; }
    public int Count { get; set; }

    public MyLinkedList()
    { }

    public MyLinkedList(T value)
    {
        this.First = new ListItem<T>(value);
        this.Last = this.First;
        this.Count = 1;
    }

    public void Add(T value)
    {
        if (this.First == null)
        {
            this.First = new ListItem<T>(value);
            this.Last = this.First;
            this.Count = 1;
        }
        else
        {
            this.Last = new ListItem<T>(value, this.Last);
            this.Count++;
        }
    }

    public void Remove(int index)
    {
        if (index < 0 || index >= this.Count)
        {
            throw new IndexOutOfRangeException("Invalid index: " + index);
        }

        var current = this.First;
        var currentIndex = 0;

        while (currentIndex < index - 1)
        {
            current = current.Next;
            currentIndex++;
        }

        // Setting the next element to be the subsequent one.
        var next = current.Next;
        next = next.Next;
        current.Next = next;
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