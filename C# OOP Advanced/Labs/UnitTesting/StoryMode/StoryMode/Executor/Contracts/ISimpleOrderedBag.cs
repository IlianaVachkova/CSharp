using System;
using System.Collections.Generic;

namespace Executor.Contracts
{
    public interface ISimpleOrderedBag<T> : IEnumerable<T> where T : IComparable<T>
    {
        int Capacity { get; }

        int Size { get; }

        void Add(T element);

        void AddAll(ICollection<T> elements);

        string JoinWith(string joiner);

        bool Remove(T element);
    }
}
