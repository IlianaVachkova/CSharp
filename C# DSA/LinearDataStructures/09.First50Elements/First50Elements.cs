using System;
using System.Collections.Generic;
using System.Linq;

namespace First50Elements
{
    public class First50Elements
    {
        public static void Main()
        {
            int firstMember = 2;
            int membersCount = 50;
            Queue<int> elements = new Queue<int>();
            List<int> resultElements = new List<int>();
            elements.Enqueue(firstMember);

            for (int i = 0; i < membersCount; i++)
            {
                int currentElement = elements.Dequeue();
                resultElements.Add(currentElement);
                elements.Enqueue(currentElement + 1);
                elements.Enqueue(2 * currentElement + 1);
                elements.Enqueue(currentElement +2);
            }

            Console.WriteLine(string.Join(" ", resultElements));
        }
    }
}
