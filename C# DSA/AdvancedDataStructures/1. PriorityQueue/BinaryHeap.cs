using System;

public class BinaryHeap<T> where T : IComparable<T>
{
    private const int DefaultCapacity = 100;
    private T[] elements;
    private int size;

    public BinaryHeap(int capacity)
    {
        this.elements = new T[capacity + 1];
        this.size = 0;
    }

    public BinaryHeap()
        : this(DefaultCapacity)
    { }

    public void Add(T element)
    {
        if (this.size == this.elements.Length - 1)
        {
            this.AutoGrow();
        }

        int position = this.size + 1;        

        while (position > 1 && this.elements[position / 2].CompareTo(element) > 0)
        {
            this.elements[position] = this.elements[position / 2];
            position /= 2;
        }

        this.elements[position] = element;
        this.size++;
    }

    public T Pop()
    {
        if (this.size == 0)
        {
            throw new IndexOutOfRangeException("The queue is empty");
        }
        // the first element is always the min
        T min = this.elements[1];
        this.elements[1] = this.elements[this.size];
        this.elements[this.size] = default(T);
        this.size--;
        this.Precolate(1);

        return min;
    }

    public T Peek()
    {
        return this.elements[1];
    }

    private void Precolate(int hole)
    {
        int child = 0;
        T elementToFillWith = this.elements[hole];

        // until we rach the end of the heap
        while (hole * 2 <= this.size)
        {
            child = hole * 2;

            // Take the smaller child (left/right)
            if (child != this.size && this.elements[child + 1].CompareTo(this.elements[child]) < 0)
            {
                child++;
            }

            // if we still have an elemenent smaller than than the precolated - we switch them
            // otherwise we found its place and break the loop
            if (this.elements[child].CompareTo(elementToFillWith) < 0)
            {
                this.elements[hole] = this.elements[child];
            }
            else
            {
                break;
            }
            hole = child;
        }
        // we put the element to its place
        this.elements[hole] = elementToFillWith;
    }

    private void AutoGrow()
    {
        var newArr = new T[this.elements.Length * 2 + 1];
        for (int i = 0; i < this.elements.Length; i++)
        {
            newArr[i] = this.elements[i];
        }
        this.elements = newArr;
    }
}