using System;
using System.Collections.Generic;

namespace SortingSearching
{
    public class Quicksorter<T> : ISorter<T> where T : IComparable<T>
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

            this.QuickSort(collection, 0, collection.Count - 1);
        }

        private void QuickSort(IList<T> collection, int left, int right)
        {
            int leftHold = left;
            int rightHold = right;
            Random rand = new Random();
            int pivot = rand.Next(left, right);
            Swap(collection, pivot, left);
            pivot = left;
            left++;

            while (right >= left)
            {
                if (collection[left].CompareTo(collection[pivot]) >= 0 && collection[right].CompareTo(collection[pivot]) < 0)
                {
                    Swap(collection, left, right);
                }
                else if (collection[left].CompareTo(collection[pivot]) >= 0)
                {
                    right--;
                }
                else if (collection[right].CompareTo(collection[pivot]) < 0)
                {
                    left++;
                }
                else
                {
                    right--;
                    left++;
                }
            }

            this.Swap(collection, pivot, right);
            pivot = right;
            if (pivot > leftHold)
            {
                QuickSort(collection, leftHold, pivot);
            }
            if (rightHold > pivot + 1)
            {
                QuickSort(collection, pivot + 1, rightHold);
            }
        }

        private void Swap(IList<T> collection, int left, int right)
        {
            T temp = collection[right];
            collection[right] = collection[left];
            collection[left] = temp;
        }
    }
}
