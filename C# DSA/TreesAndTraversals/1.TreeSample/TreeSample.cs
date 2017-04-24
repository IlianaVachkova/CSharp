using System;
using System.Collections.Generic;

namespace TraverseTree
{
    public class TreeSample
    {
        public static int allPathsWithSum = 0;
        public static int allSubtreesWithSum = 0;

        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var nodes = new List<Node<int>>();
            for (int i = 0; i < n; i++)
            {
                var currentNode = new Node<int>(i);
                nodes.Add(currentNode);
            }

            for (int i = 0; i < nodes.Count - 1; i++)
            {
                var line = Console.ReadLine();
                var stringNodes = line.Split();

                var parentNodeValue = int.Parse(stringNodes[0]);
                var childNodeValue = int.Parse(stringNodes[1]);

                foreach (var node in nodes)
                {
                    if (node.Value == parentNodeValue)
                    {
                        node.AddChild(nodes[childNodeValue]);
                    }
                }
            }

            // Task 1 - Find the root node
            Console.WriteLine("Root: " + FindRoot(nodes).Value);

            // Task 2 - Find all leaf nodes
            Console.Write("Leaves: ");
            foreach (var leaf in FindLeaves(nodes))
            {
                Console.Write("{0} ", leaf.Value);
            }
            Console.WriteLine();

            // Task 3 - Find all middle nodes
            Console.Write("Middle nodes: ");
            foreach (var middleNode in FindMiddleNodes(nodes))
            {
                Console.Write("{0} ", middleNode.Value);
            }
            Console.WriteLine();

            // Task 4 - Find the longest path in the tree
            var root = FindRoot(nodes);
            int longestPath = FindLongestPath(root);
            Console.WriteLine("Longest path from root: {0}", longestPath);

            // Task 5 - Find all paths in the tree with given sum S of their nodes
            int s = 9;
            FindPathWithSum(root, 0, s);
            Console.WriteLine("All paths with sum {0} are {1}", s, allPathsWithSum);

            // Task 6 - Find all subtrees with given sum S of their nodes
            s = 21;
            FindAllSubtreesWithSum(root, s);
            Console.WriteLine("All subtrees with sum {0} are {1}", s, allSubtreesWithSum);
        }

        private static Node<int> FindRoot(List<Node<int>> nodes)
        {
            foreach (var node in nodes)
            {
                if (!node.HasParent)
                {
                    return node;
                }
            }

            throw new ArgumentException("The tree has no root!");
        }

        private static List<Node<int>> FindLeaves(List<Node<int>> nodes)
        {
            var leaves = new List<Node<int>>();

            foreach (var node in nodes)
            {
                if (node.Children.Count == 0)
                {
                    leaves.Add(node);
                }
            }

            return leaves;
        }

        private static List<Node<int>> FindMiddleNodes(List<Node<int>> nodes)
        {
            var middleNodes = new List<Node<int>>();

            foreach (var node in nodes)
            {
                if (node.Children.Count > 0 && node.HasParent)
                {
                    middleNodes.Add(node);
                }
            }

            return middleNodes;
        }

        private static int FindLongestPath(Node<int> root)
        {
            if (root.Children.Count == 0)
            {
                return 0;
            }

            int longestPath = 0;
            foreach (var child in root.Children)
            {
                longestPath = Math.Max(longestPath, FindLongestPath(child));
            }

            return longestPath + 1;
        }

        private static void FindPathWithSum(Node<int> node, int currentSum, int searchedSum)
        {
            currentSum += node.Value;

            foreach (var item in node.Children)
            {
                FindPathWithSum(item, currentSum, searchedSum);
            }

            if (currentSum == searchedSum && node.ChildrenCount == 0)
            {
                allPathsWithSum++;
            }
        }

        private static void FindAllSubtreesWithSum(Node<int> node, int searchedSum)
        {
            Queue<Node<int>> subTree = new Queue<Node<int>>();
            subTree.Enqueue(node);

            while (subTree.Count > 0)
            {
                int sum = 0;
                var currentNode = subTree.Dequeue();
                sum += currentNode.Value;
                foreach (var item in currentNode.Children)
                {
                    sum += item.Value;
                    subTree.Enqueue(item);
                }
                if (sum == searchedSum)
                {
                    allSubtreesWithSum++;
                }
            }
        }
    }
}
