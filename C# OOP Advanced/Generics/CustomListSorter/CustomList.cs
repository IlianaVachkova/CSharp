using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomListSorter
{
    public class CustomList<T> where T : IComparable
    {
        private IList<T> elements;

        public CustomList()
            : this(Enumerable.Empty<T>())
        {

        }
        public CustomList(IEnumerable<T> elements)
        {
            this.elements = new List<T>(elements);
        }

        public T Max
        {
            get
            {
                return this.elements.Max();
            }
        }

        public T Min
        {
            get
            {
                return this.elements.Min();
            }
        }

        public IEnumerable<T> Elements
        {
            get
            {
                return this.elements;
            }
        }
        public void Add(T element)
        {
            this.elements.Add(element);
        }

        public T Remove(int index)
        {
            this.ValidateIndex(index);

            T elementToBeRemoved = this.elements[index];
            this.elements.Remove(elementToBeRemoved);

            return elementToBeRemoved;
        }

        public bool Contains(T element)
        {
            return this.elements.Contains(element);
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            this.ValidateIndex(firstIndex);
            this.ValidateIndex(secondIndex);

            T temp = elements[firstIndex];
            elements[firstIndex] = elements[secondIndex];
            elements[secondIndex] = temp;
        }

        public int CountGreatherThan(T element)
        {
            int count = elements.Count(e => e.CompareTo(element) > 0);
            return count;
        }

        public void Sort()
        {
            var sortedElements = this.elements.ToList();
            sortedElements.Sort();
            this.elements = sortedElements;
        }

        private void ValidateIndex(int index)
        {
            if (index < 0 || index >= this.elements.Count)
            {
                throw new ArgumentException("Invalid index");
            }
        }
    }
}
