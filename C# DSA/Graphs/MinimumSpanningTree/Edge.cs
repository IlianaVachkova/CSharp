using System;

public class Edge : IComparable<Edge>
{
    public string StartNode { get; set; }
    public string EndNode { get; set; }
    public int Weight { get; set; }

    public Edge(string startNode, string endNode, int weight)
    {
        this.StartNode = startNode;
        this.EndNode = endNode;
        this.Weight = weight;
    }

    public int CompareTo(Edge other)
    {
        return this.Weight.CompareTo(other.Weight);
    }

    public override string ToString()
    {
        return string.Format("{0}->{1} - {2}m",
            this.StartNode, this.EndNode, this.Weight);
    }
}