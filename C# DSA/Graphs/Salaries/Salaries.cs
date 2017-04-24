using System;
using System.Collections.Generic;

public class Node
{
    public int Value { get; set; }
    public long Salary { get; set; }
    public bool HasParent { get; set; }
    public List<Node> Children { get; set; }
    public int ChildrenCount { get { return this.Children.Count; } }

    public Node(int value)
    {
        this.Value = value;
        this.Salary = 0;
        this.Children = new List<Node>();
    }

    public void AddChild(Node child)
    {
        child.HasParent = true;
        this.Children.Add(child);
    }
}

public class Salaries
{
    static long allSalaries = 0;
    static bool[] visited;

    static void Main()
    {
#if DEBUG
        Console.SetIn(new System.IO.StreamReader("..//..//input.txt"));
#endif

        int n = int.Parse(Console.ReadLine());
        var graph = new Node[n];
        visited = new bool[n];

        for (int row = 0; row < n; row++)
        {
            string line = Console.ReadLine();
            if (graph[row] == null)
            {
                var node = new Node(row);
                graph[row] = node;
            }

            for (int col = 0; col < line.Length; col++)
            {
                if (line[col] == 'Y')
                {
                    if (graph[col] == null)
                    {
                        var node = new Node(col);
                        graph[col] = node;
                    }
                    graph[row].AddChild(graph[col]);
                }
            }
        }

        foreach (var item in graph)
        {
            if (!item.HasParent)
            {
                FindSalary(item);
            }
        }

        Console.WriteLine(allSalaries);
    }
    
    public static void FindSalary(Node root)
    {
        if (!visited[root.Value])
        {
            visited[root.Value] = true;
            if (root.ChildrenCount == 0)
            {
                root.Salary = 1;
                allSalaries += root.Salary;
            }
            else
            {                
                long salary = 0;
                foreach (var node in root.Children)
                {
                    FindSalary(node);
                    salary += node.Salary;
                }
                root.Salary = salary;
                allSalaries += root.Salary;
            }
        }
    }
}