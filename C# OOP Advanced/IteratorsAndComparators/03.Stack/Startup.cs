using System;

namespace Stack
{
    public class Startup
    {
        public static void Main()
        {
            Stack<string> stack = new Stack<string>();

            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] parameters = command.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                string action = parameters[0];
                switch (action)
                {
                    case "Push":
                        for (int i = 1; i < parameters.Length; i++)
                        {
                            stack.Push(parameters[i]);
                        }
                        break;
                    case "Pop":
                        try
                        {
                            stack.Pop();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                }

                command = Console.ReadLine();
            }

            try
            {
                for (int i = 0; i < 2; i++)
                {
                    foreach (var element in stack)
                    {
                        Console.WriteLine(element);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
