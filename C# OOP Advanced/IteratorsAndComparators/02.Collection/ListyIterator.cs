using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Collection
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private IList<T> elements;
        private int currentIndex;

        public ListyIterator(IEnumerable<T> collection)
        {
            this.elements = new List<T>(collection);
            this.currentIndex = 0;
        }

        public ListyIterator()
            : this(Enumerable.Empty<T>())
        {
        }

        public bool Move()
        {
            if (this.HasNext())
            {
                this.currentIndex++;
                return true;
            }

            return false;
        }

        public bool HasNext()
        {
            if (this.currentIndex < this.elements.Count - 1)
            {
                return true;
            }

            return false;
        }

        public T Print()
        {
            if (this.elements.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            return this.elements[this.currentIndex];
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.elements.Count; i++)
            {
                yield return this.elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
