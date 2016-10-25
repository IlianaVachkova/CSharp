using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomList
{
    public class MyCustomList<T> where T : IComparable
    {
        public MyCustomList()
        {
            this.List = new List<T>();
        }

        public List<T> List { get; private set; }

        public void Add(T element)
        {
            this.List.Add(element);
        }

        public T Remove(int index)
        {
            T elementToBeRemoved = this.List[index];
            this.List.RemoveAt(index);

            return elementToBeRemoved;
        }

        public bool Contains(T element)
        {
            if (!this.List.Contains(element))
            {
                return false;
            }

            return true;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            T tempValue = this.List[firstIndex];
            this.List[firstIndex] = this.List[secondIndex];
            this.List[secondIndex] = tempValue;
        }

        public int CountGreaterThan(T element)
        {
            int counter = 0;

            foreach (var el in this.List)
            {
                if (el.CompareTo(element) > 0)
                {
                    counter++;
                }
            }

            return counter;
        }

        public T Max()
        {
            return this.List.Max();
        }

        public T Min()
        {
            return this.List.Min();
        }

        public string Print()
        {
            StringBuilder result = new StringBuilder();

            foreach (var element in this.List)
            {
                result.AppendLine(element.ToString());
            }

            return result.ToString();
        }
    }
}
