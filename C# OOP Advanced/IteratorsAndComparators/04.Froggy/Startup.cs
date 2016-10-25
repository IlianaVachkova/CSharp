using System;
using System.Linq;

namespace Froggy
{
    public class Startup
    {
        public static void Main()
        {
            int[] stones = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Lake lake = new Lake(stones);
            Console.WriteLine(string.Join(", ", lake));
        }
    }
}
