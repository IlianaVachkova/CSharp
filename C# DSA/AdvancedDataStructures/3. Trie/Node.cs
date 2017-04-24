using System;
using System.Collections.Generic;

public class Node
{
    public char Letter { get; set; }

    public bool Last { get; set; }

    public Dictionary<char, Node> Children { get; set; }

    public Node(char ch)
    {
        this.Children = new Dictionary<char, Node>();
        this.Last = false;
        this.Letter = ch;
    }

    public Node ChildNode(char ch)
    {
        if (this.Children == null)
        {
            throw new NullReferenceException("The node has no children");
        }

        if (this.Children.ContainsKey(ch))
        {
            return this.Children[ch];
        }

        return null;
    }

    public override bool Equals(object obj)
    {
        if (obj == null)
        {
            return false;
        }

        if (this.GetType() != obj.GetType())
        {
            return false;
        }

        var other = (Node)obj;
        return this.Letter == other.Letter;
    }

    public override int GetHashCode()
    {
        int hash = 13;
        hash = (hash * 7) + this.Letter.GetHashCode();
        return hash;
    }
}