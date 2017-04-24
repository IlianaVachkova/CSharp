using System;
using System.Collections.Generic;

public class HashedSet<T>
{
    private HashTable<T, int> elements;

    public int Count { get; private set; }

    public HashedSet()
    {
        this.elements = new HashTable<T, int>();
        this.Count = 0;
    }

    public void Add(T key)
    {
        if (!this.elements.ContainsKey(key))
        {
            this.elements.Add(key, 1);
        }
        else
        {
            this.elements[key]++;
        }
        this.Count++;
    }

    public bool Find(T key)
    {
        if (!this.elements.ContainsKey(key))
        {
            return false;
        }

        return true;
    }

    public void Remove(T key)
    {
        if (!this.elements.ContainsKey(key))
        {
            throw new KeyNotFoundException("There is no such key: " + key);
        }

        if (this.elements[key] > 1)
        {
            this.elements[key]--;
        }
        else
        {
            this.elements.Remove(key);
        }

        this.Count--;
    }

    public void RemoveAll(T key)
    {
        if (!this.elements.ContainsKey(key))
        {
            throw new KeyNotFoundException("There is no such key: " + key);
        }

        this.Count -= this.elements.Count;
        this.elements.Remove(key);
    }

    public void Clear()
    {
        this.elements.Clear();
        this.Count = 0;
    }
}