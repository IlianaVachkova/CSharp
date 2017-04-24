using System;
using System.Collections.Generic;

namespace SortingSearching
{
    public class MergeSorter<T> : ISorter<T> where T : IComparable<T>
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

            var sorted = this.MergeSort(collection);
            for (int i = 0; i < sorted.Count; i++)
            {
                collection[i] = sorted[i];
            }
        }

        private IList<T> MergeSort(IList<T> unsorted)
        {
            if (unsorted.Count <= 1)
            {
                return unsorted;
            }

            IList<T> left = new List<T>();
            IList<T> right = new List<T>();
            int middle = unsorted.Count / 2;

            for (int i = 0; i < middle; i++)
            {
                left.Add(unsorted[i]);
            }

            for (int j = middle; j < unsorted.Count; j++)
            {
                right.Add(unsorted[j]);
            }

            left = this.MergeSort(left);
            right = this.MergeSort(right);

            return this.Merge(left, right);
        }

        private IList<T> Merge(IList<T> left, IList<T> right)
        {
            IList<T> merged = new List<T>();
            while (left.Count > 0 && right.Count > 0)
            {
                if (left[0].CompareTo(right[0]) < 0)
                {
                    merged.Add(left[0]);
                    left.RemoveAt(0);
                }
                else
                {
                    merged.Add(right[0]);
                    right.RemoveAt(0);
                }
            }

            while (left.Count > 0)
            {
                merged.Add(left[0]);
                left.RemoveAt(0);
            }
            while (right.Count > 0)
            {
                merged.Add(right[0]);
                right.RemoveAt(0);
            }

            return merged;
        }
    }
}
