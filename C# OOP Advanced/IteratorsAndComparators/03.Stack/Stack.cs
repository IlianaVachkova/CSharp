using System;
using System.Collections;
using System.Collections.Generic;

namespace Stack
{
    public class Stack<T> : IEnumerable<T>
    {
        private const int InitialCapacity = 16;
        private T[] elements;

        public Stack()
        {
            this.elements = new T[InitialCapacity];
        }

        public int Count { get; private set; }

        public int Cpacity
        {
            get { return this.elements.Length; }
        }

        public void Push(T element)
        {
            if (this.Count == this.elements.Length)
            {
                this.IncreaseSequence();
            }

            this.elements[this.Count] = element;
            this.Count++;
        }

        public T Pop()
        {
            CheckForEmptyStack();

            this.Count--;
            T resultElement = this.elements[this.Count];
            return resultElement;
        }

        private void IncreaseSequence()
        {
            var newElements = new T[2 * this.elements.Length];
            Array.Copy(this.elements, newElements, this.Count);
            this.elements = newElements;
        }

        private void CheckForEmptyStack()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("No elements");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.Count - 1; i >= 0; i--)
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
