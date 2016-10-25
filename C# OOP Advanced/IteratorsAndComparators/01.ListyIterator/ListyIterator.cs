using System;
using System.Collections.Generic;
using System.Linq;

namespace ListyIterator
{
    public class ListyIterator<T>
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
    }
}
