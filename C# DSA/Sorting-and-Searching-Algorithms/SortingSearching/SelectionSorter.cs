using System;
using System.Collections.Generic;

namespace SortingSearching
{
    public class SelectionSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException("The collection cannot be null.");
            }

            if (collection.Count == 0)
            {
                throw new ArgumentException("Cannot sort an empty collection");
            }

            for (int sortedSize = 0; sortedSize < collection.Count; sortedSize++)
            {
                int minElementIndex = sortedSize;
                T minElementValue = collection[sortedSize];
                for (int i = sortedSize + 1; i < collection.Count; i++)
                {
                    if (collection[i].CompareTo(minElementValue) < 0)
                    {
                        minElementIndex = i;
                        minElementValue = collection[i];
                    }
                }

                collection[minElementIndex] = collection[sortedSize];
                collection[sortedSize] = minElementValue;
            }
        }
    }
}
