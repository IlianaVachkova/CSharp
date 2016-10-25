using System;

namespace LinkedListTraversal
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            LinkedList<int> sequence = new LinkedList<int>();
            int commandsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsCount; i++)
            {
                string[] command = Console.ReadLine().Split();
                string action = command[0];
                int number = int.Parse(command[1]);

                switch (action)
                {
                    case "Add": sequence.Add(number); break;
                    case "Remove":
                        int removeIndex = sequence.FirstIndexOf(number);
                        if (removeIndex > -1)
                        {
                            sequence.Remove(sequence.FirstIndexOf(number));
                        }
                        break;
                }
            }

            Console.WriteLine(sequence.Count);
            Console.WriteLine(string.Join(" ", sequence));
        }
    }
}
