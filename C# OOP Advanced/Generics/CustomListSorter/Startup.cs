using System;

namespace CustomListSorter
{
    public class CustomList
    {
        public static void Main(string[] args)
        {
            CustomList<string> elements = new CustomList<string>();
            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] cmdArgs = command.Split();
                string action = cmdArgs[0];
                switch (action)
                {
                    case "Add":
                        elements.Add(cmdArgs[1]);
                        break;
                    case "Remove":
                        elements.Remove(int.Parse(cmdArgs[1]));
                        break;
                    case "Contains":
                        Console.WriteLine(elements.Contains(cmdArgs[1]));
                        break;
                    case "Swap":
                        elements.Swap(int.Parse(cmdArgs[1]), int.Parse(cmdArgs[2]));
                        break;
                    case "Greater":
                        int count = elements.CountGreatherThan(cmdArgs[1]);
                        Console.WriteLine(count);
                        break;
                    case "Max":
                        Console.WriteLine(elements.Max);
                        break;
                    case "Min":
                        Console.WriteLine(elements.Min);
                        break;
                    case "Print":
                        foreach (var element in elements.Elements)
                        {
                            Console.WriteLine(element);
                        }
                        break;
                    case "Sort":
                        elements.Sort();
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine();
            }
        }
    }
}
