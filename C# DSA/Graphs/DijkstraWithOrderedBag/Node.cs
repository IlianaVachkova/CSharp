using System;

public class Node : IComparable
{
    public int ID { get; private set; }
    public int DijkstraDistance { get; set; }

    public Node(int id)
    {
        this.ID = id;
    }

    public int CompareTo(object other)
    {
        return this.DijkstraDistance.CompareTo((other as Node).DijkstraDistance);
    }
}