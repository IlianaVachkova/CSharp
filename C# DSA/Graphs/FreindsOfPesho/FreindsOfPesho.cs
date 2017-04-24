using System;
using System.Collections.Generic;

public class FreindsOfPesho
{
    public static int[] distance;
    public static int?[] previous;
    public static HashSet<int> setOfNodes = new HashSet<int>();

    public static void Main()
    {
#if DEBUG
        Console.SetIn(new System.IO.StreamReader("..//..//input.txt"));
#endif

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

        int[,] graph = new int[nodesCount + 1, nodesCount + 1];
        distance = new int[nodesCount + 1];
        previous = new int?[nodesCount + 1];

        for (int i = 0; i < connectionsCount; i++)
        {
            tokens = Console.ReadLine().Split();
            int firstNode = int.Parse(tokens[0]);
            int secondNode = int.Parse(tokens[1]);
            int distanceBetween = int.Parse(tokens[2]);

            graph[firstNode, secondNode] = distanceBetween;
            graph[secondNode, firstNode] = distanceBetween;
        }

        int min = int.MaxValue;

        foreach (var hospital in hospitals)
        {
            Dijkstra(graph, hospital);
            int minPathsSum = 0;
            for (int i = 1; i < distance.Length; i++)
            {
                if (!hospitals.Contains(i))
                {
                    minPathsSum += distance[i];
                }
            }

            if (minPathsSum < min)
            {
                min = minPathsSum;
            }
        }

        Console.WriteLine(min);
    }

    public static void Dijkstra(int[,] graph, int start)
    {
        for (int i = 1; i < graph.GetLength(0); i++)
        {
            distance[i] = int.MaxValue;
            previous[i] = null;
            setOfNodes.Add(i);
        }

        distance[start] = 0;

        while (setOfNodes.Count != 0)
        {
            int minNode = int.MaxValue;

            foreach (var node in setOfNodes)
            {
                if (minNode > distance[node])
                {
                    minNode = node;
                }
            }

            setOfNodes.Remove(minNode);

            if (minNode == int.MaxValue)
            {
                break;
            }

            for (int i = 1; i < graph.GetLength(0); i++)
            {
                if (graph[minNode, i] > 0)
                {
                    int potencialDistance = distance[minNode] + graph[minNode, i];

                    if (potencialDistance < distance[i])
                    {
                        distance[i] = potencialDistance;
                        previous[i] = minNode;
                    }
                }
            }
        }
    }
}