using System;
using System.Collections.Generic;

namespace TraverseTree
{
    public class Node<T>
    {
        public T Value { get; private set; }
        public List<Node<T>> Children { get; private set; }
        public bool HasParent { get; set; }
        public int ChildrenCount { get { return this.Children.Count; } }

        public Node(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("Cannot insert null value!");
            }

            this.Value = value;
            this.Children = new List<Node<T>>();
        }

        public void AddChild(Node<T> child)
        {
            if (child == null)
            {
                throw new ArgumentNullException("Cannot insert null value!");
            }

            child.HasParent = true;
            this.Children.Add(child);
        }

        public Node<T> GetChild(int index)
        {
            if (index < 0 || index >= this.Children.Count)
            {
                throw new IndexOutOfRangeException(
                    "The searched index is otuside the boudries.");
            }

            return this.Children[index];
        }
    }
}