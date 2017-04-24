using System;
using Wintellect.PowerCollections;
using System.Collections.Generic;

public class BiDictionary<K1, K2, T>
{
    private MultiDictionary<K1, T> firstKeyValues;
    private MultiDictionary<K2, T> secondKeyValues;

    public BiDictionary()
    {
        this.firstKeyValues = new MultiDictionary<K1, T>(true);
        this.secondKeyValues = new MultiDictionary<K2, T>(true);
    }

    public void Add(K1 firstKey, K2 secondKey, T value)
    {
        this.firstKeyValues.Add(firstKey, value);
        this.secondKeyValues.Add(secondKey, value);
    }

    public bool ContainsKey(object key)
    {
        if (!(key is K1) && !(key is K2))
        {
            throw new InvalidCastException("The type of the key " +
                key.GetType().Name + " you are looking for is not present.");
        }

        if (key is K1)
        {
            var firstKey = (K1)key;
            if (this.firstKeyValues.ContainsKey(firstKey))
            {
                return true;
            }
        }

        if (key is K2)
        {
            var secondKey = (K2)key;
            if (this.secondKeyValues.ContainsKey(secondKey))
            {
                return true;
            }
        }

        return false;
    }

    public bool ContainsKeys(K1 firstKey, K2 secondKey)
    {
        return this.firstKeyValues.ContainsKey(firstKey) &&
            this.secondKeyValues.ContainsKey(secondKey);
    }

    public void Remove(object key)
    {
        if (!(key is K1) && !(key is K2))
        {
            throw new InvalidCastException("The type of the key " +
                key.GetType().Name + " you are looking for is not present.");
        }

        bool keyFound = false;
        if (key is K1)
        {
            var firstKey = (K1)key;
            if (this.firstKeyValues.ContainsKey(firstKey))
            {
                this.firstKeyValues.Remove(firstKey);
                keyFound = true;
            }
        }

        if (key is K2)
        {
            var secondKey = (K2)key;
            if (this.secondKeyValues.ContainsKey(secondKey))
            {
                this.secondKeyValues.Remove(secondKey);
                keyFound = true;
            }
        }

        if (!keyFound)
        {
            throw new KeyNotFoundException("The key you are looking for " +
                key + " is not found.");
        }
    }

    public ICollection<T> GetValuesByKey(object key)
    {
        if (!(key is K1) && !(key is K2))
        {
            throw new InvalidCastException("The type of the key " +
                key.GetType().Name + " you are looking for is not present.");
        }

        if (key is K1)
        {
            var firstKey = (K1)key;
            if (this.firstKeyValues.ContainsKey(firstKey))
            {
                return this.firstKeyValues[firstKey];
            }
        }

        if (key is K2)
        {
            var secondKey = (K2)key;
            if (this.secondKeyValues.ContainsKey(secondKey))
            {
                return this.secondKeyValues[secondKey];
            }
        }

        throw new KeyNotFoundException("The key you are looking for " +
                key + " is not found.");
    }

    public ICollection<T> GetValuesByKeys(K1 firstKey, K2 secondKey)
    {
        if (!this.ContainsKeys(firstKey, secondKey))
        {
            throw new KeyNotFoundException("The are no suck keys.");
        }

        return this.firstKeyValues[firstKey];
    }
}