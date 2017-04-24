using System;
using System.Collections.Generic;

namespace SortingSearching
{
    public class SortableCollection<T> where T : IComparable<T>
    {
        private readonly IList<T> items;

        public SortableCollection()
        {
            this.items = new List<T>();
        }

        public SortableCollection(IEnumerable<T> items)
        {
            this.items = new List<T>(items);
        }

        public IList<T> Items
        {
            get
            {
                return this.items;
            }
        }

        public void Sort(ISorter<T> sorter)
        {
            sorter.Sort(this.items);
        }

        public bool LinearSearch(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("The item cannot be null");
            }

            foreach (var element in this.items)
            {
                if (element.CompareTo(item) == 0)
                {
                    return true;
                }
            }

            return false;
        }

        public bool BinarySearch(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("The item cannot be null");
            }

            var sorter = new MergeSorter<T>();
            this.Sort(sorter);

            int left = 0;
            int right = this.items.Count - 1;
            int middle = 0;

            while (left <= right)
            {
                middle = (left + right) / 2;
                if (item.CompareTo(this.items[middle]) == 0)
                {
                    return true;
                }
                else if (item.CompareTo(this.items[middle]) < 0)
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }

            return false;
        }

        public void Shuffle()
        {
            Random random = new Random();
            int itemsCount = this.items.Count;
            while (itemsCount > 1)
            {
                itemsCount--;
                int randomIndex = random.Next(itemsCount + 1);
                T value = this.items[randomIndex];
                this.items[randomIndex] = this.items[itemsCount];
                this.items[itemsCount] = value;
            }
        }

        public void PrintAllItemsOnConsole()
        {
            for (int i = 0; i < this.items.Count; i++)
            {
                if (i == 0)
                {
                    Console.Write(this.items[i]);
                }
                else
                {
                    Console.Write(" " + this.items[i]);
                }
            }

            Console.WriteLine();
        }
    }
}
