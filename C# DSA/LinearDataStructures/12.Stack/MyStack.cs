using System;
using System.Text;

public class MyStack<T>
{
    private T[] elements;
    private int count;

    public MyStack(int capacity)
    {
        this.elements = new T[capacity];
        this.count = 0;
    }

    public MyStack()
        : this(4)
    { }

    public int Count
    {
        get
        {
            return this.count;
        }
    }

    public void Push(T element)
    {
        if (this.count >= elements.Length)
        {
            this.AutoGrow();
        }
        this.elements[count] = element;
        count++;
    }

    public T Pop()
    {
        this.count--;
        T popResult = this.elements[count];
        return popResult;
    }

    public T Peek()
    {
        return this.elements[this.count - 1];
    }

    private void AutoGrow()
    {
        T[] extended = new T[this.elements.Length * 2];
        for (int i = 0; i < this.elements.Length; i++)
        {
            extended[i] = this.elements[i];
        }
        this.elements = extended;
    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < this.count; i++)
        {
            result.AppendFormat("{0} ", this.elements[i]);
        }

        return result.ToString();
    }
}