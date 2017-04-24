using System;
using System.Collections.Generic;

public class HashTable<K, T> : IEnumerable<KeyValuePair<K, T>>
{
    private int capacity = 16;
    private LinkedList<KeyValuePair<K, T>>[] items;

    public HashTable()
    {
        this.items = new LinkedList<KeyValuePair<K, T>>[this.capacity];
        this.Count = 0;
    }

    public int Count { get; private set; }

    public T this[K key]
    {
        get
        {
            return this.Find(key);
        }
        set
        {
            int index = this.GetArrayPosition(key);
            this.items[index].First.Value = new KeyValuePair<K, T>(key, value);
        }
    }

    public List<K> Keys
    {
        get
        {
            var resultList = new List<K>();
            foreach (var item in this.items)
            {
                if (item != null)
                {
                    resultList.Add(item.First.Value.Key);
                }
            }
            return resultList;
        }
    }

    public void Add(K key, T value)
    {
        if (this.Count >= 0.75 * this.capacity)
        {
            this.ExtendCapacity();
        }

        int index = GetArrayPosition(key);
        if (this.items[index] == null)
        {
            this.items[index] = new LinkedList<KeyValuePair<K, T>>();
        }
        KeyValuePair<K, T> elementToAdd = new KeyValuePair<K, T>(key, value);
        this.items[index].AddLast(elementToAdd);
        this.Count++;
    }

    public T Find(K key)
    {
        int index = this.GetArrayPosition(key);
        var linkedListToSearchIn = this.items[index];
        if (linkedListToSearchIn != null)
        {
            foreach (var item in linkedListToSearchIn)
            {
                if (item.Key.Equals(key))
                {
                    return item.Value;
                }
            }
        }

        throw new KeyNotFoundException("There is no such key: " + key);
    }

    public void Remove(K key)
    {
        int index = this.GetArrayPosition(key);
        if (!this.items[index].First.Value.Key.Equals(key))
        {
            throw new KeyNotFoundException("There is no such key: " + key);
        }

        this.items[index].RemoveFirst();
        this.Count--;
    }

    public void RemoveAll(K key)
    {
        int index = this.GetArrayPosition(key);
        this.Count -= this.items[index].Count;
        this.items[index].Clear();
    }

    public void Clear()
    {
        this.capacity = 16;
        this.items = new LinkedList<KeyValuePair<K, T>>[this.capacity];
        this.Count = 0;
    }

    public bool ContainsKey(K key)
    {
        int index = this.GetArrayPosition(key);
        if (this.items[index] != null && this.items[index].Count > 0)
        {
            return true;
        }

        return false;
    }

    private int GetArrayPosition(K key)
    {
        int position = key.GetHashCode() % this.capacity;
        return Math.Abs(position);
    }

    private void ExtendCapacity()
    {
        this.capacity *= 2;
        var extendedArray = new LinkedList<KeyValuePair<K, T>>[this.capacity];
        for (int i = 0; i < this.items.Length; i++)
        {
            extendedArray[i] = this.items[i];
        }
        this.items = extendedArray;
    }

    public IEnumerator<KeyValuePair<K, T>> GetEnumerator()
    {
        foreach (var list in this.items)
        {
            if (list != null)
            {
                foreach (var listItem in list)
                {
                    yield return listItem;
                }
            }
        }
    }

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}