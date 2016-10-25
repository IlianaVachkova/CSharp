using System;

namespace GenericBox
{
    public class Startup
    {
        public static void Main()
        {
            int numOfStr = int.Parse(Console.ReadLine());

            //example with string
            /*
            for (int i = 0; i < numOfStr; i++)
            {
                string inputStr = Console.ReadLine();
                Console.WriteLine(new Box<string>(inputStr).ToString());
            }
            */

            //exapmle with int
            for (int i = 0; i < numOfStr; i++)
            {
                int inputInt = int.Parse(Console.ReadLine());
                Console.WriteLine(new Box<int>(inputInt).ToString());
            }
        }
    }
}
