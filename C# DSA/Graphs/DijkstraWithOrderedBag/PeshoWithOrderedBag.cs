using System;
using Wintellect.PowerCollections;
using System.Collections.Generic;

public class PeshoWithOrderedBag
{
    public static void Main()
    {
#if DEBUG
        Console.SetIn(new System.IO.StreamReader("../../input.txt"));
#endif

        var graph = new Dictionary<Node, List<Connection>>();
        var tokens = Console.ReadLine().Split();
        int nodesCount = int.Parse(tokens[0]);
        int connectionsCount = int.Parse(tokens[1]);
        int hospitalsCount = int.Parse(tokens[2]);
        tokens = Console.ReadLine().Split();
        var hospitals = new HashSet<int>();

        for (int i = 0; i < hospitalsCount; i++)
        {
            hospitals.Add(int.Parse(tokens[i]));
        }

        var nodes = new Dictionary<int, Node>();
        for (int i = 0; i < connectionsCount; i++)
        {
            tokens = Console.ReadLine().Split();
            int firstNodeValue = int.Parse(tokens[0]);
            int secondNodeValue = int.Parse(tokens[1]);
            int distanceBetween = int.Parse(tokens[2]);            

            if (!nodes.ContainsKey(firstNodeValue))
            {
                var firstNode = new Node(firstNodeValue);
                nodes.Add(firstNodeValue, firstNode);
                graph.Add(firstNode, new List<Connection>());
            }
            if (!nodes.ContainsKey(secondNodeValue))
            {
                var secondNode = new Node(secondNodeValue);
                nodes.Add(secondNodeValue, secondNode);
                graph.Add(secondNode, new List<Connection>());
            }

            graph[nodes[firstNodeValue]].Add(new Connection(nodes[secondNodeValue], distanceBetween));
            graph[nodes[secondNodeValue]].Add(new Connection(nodes[firstNodeValue], distanceBetween));
        }

        var min = int.MaxValue;

        foreach (var hospital in hospitals)
        {
            Dijkstra(graph, nodes[hospital]);

            var sum = 0;
            foreach (var node in nodes)
            {
                if (!hospitals.Contains(node.Key))
                {
                    sum += node.Value.DijkstraDistance;
                }
            }

            if (sum < min)
            {
                min = sum;
            }
        }

        Console.WriteLine(min);
    }

    public static void Dijkstra(Dictionary<Node, List<Connection>> graph, Node start)
    {
        var queue = new OrderedBag<Node>();

        foreach (var node in graph)
        {
            node.Key.DijkstraDistance = int.MaxValue;
        }

        start.DijkstraDistance = 0;
        queue.Add(start);

        while (queue.Count > 0)
        {
            Node currentNode = queue.RemoveFirst();

            if (currentNode.DijkstraDistance == int.MaxValue)
            {
                break;
            }

            foreach (var neighbour in graph[currentNode])
            {
                int potDistance = currentNode.DijkstraDistance + neighbour.Distance;

                if (potDistance < neighbour.Node.DijkstraDistance)
                {
                    neighbour.Node.DijkstraDistance = potDistance;
                    queue.Add(neighbour.Node);
                }
            }
        }
    }
}