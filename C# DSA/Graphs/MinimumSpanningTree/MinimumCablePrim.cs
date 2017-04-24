using System;
using System.Collections.Generic;

public class MinimumCablePrim
{
    public static HashSet<string> used = new HashSet<string>();
    public static SortedSet<Edge> priority = new SortedSet<Edge>();
    public static HashSet<Edge> mpdNodes = new HashSet<Edge>();
    public static List<Edge> edges = new List<Edge>();

    public static void Main()
    {
        InitializeGraph();

        // Adding edges that connect the house A with B, C, D
        for (int i = 0; i < edges.Count; i++)
        {
            if (edges[i].StartNode == edges[0].StartNode)
            {
                priority.Add(edges[i]);
            }
        }
        used.Add(edges[0].StartNode);

        FindMinimumSpanningTree();
        Console.WriteLine(string.Join("\n", mpdNodes));
    }

    public static void InitializeGraph()
    {
        edges.Add(new Edge("A", "C", 5));
        edges.Add(new Edge("A", "B", 4));
        edges.Add(new Edge("A", "D", 9));
        edges.Add(new Edge("B", "D", 2));
        edges.Add(new Edge("C", "D", 20));
        edges.Add(new Edge("C", "E", 7));
        edges.Add(new Edge("D", "E", 8));
        edges.Add(new Edge("E", "F", 12));
    }

    public static void FindMinimumSpanningTree()
    {
        while (priority.Count > 0)
        {
            Edge edge = priority.Min;
            priority.Remove(edge);

            if (!used.Contains(edge.EndNode))
            {
                used.Add(edge.EndNode);
                mpdNodes.Add(edge);
                AddEdges(edge);
            }
        }
    }

    public static void AddEdges(Edge edge)
    {
        for (int i = 0; i < edges.Count; i++)
        {
            if (!mpdNodes.Contains(edges[i]))
            {
                if (edge.EndNode == edges[i].StartNode &&
                    !used.Contains(edges[i].EndNode))
                {
                    priority.Add(edges[i]);
                }
            }
        }
    }
}