using System;

namespace CustomList
{
    public class Startup
    {
        public static void Main()
        {
            MyCustomList<string> elements = new MyCustomList<string>();

            string command = Console.ReadLine();
            while (command!="END")
            {
                string[] commandArgs = command.Split(' ');

                switch (commandArgs[0])
                {
                    case "Add": elements.Add(commandArgs[1]); break;
                    case "Remove": elements.Remove(int.Parse(commandArgs[1])); break;
                    case "Contains": elements.Contains(commandArgs[1]); break;
                    case "Swap": elements.Swap(int.Parse(commandArgs[1]), int.Parse(commandArgs[2])); break;
                    case "Greater": elements.CountGreaterThan(commandArgs[1]); break;
                    case "Max": elements.Max(); break;
                    case "Min": elements.Min(); break;
                    case "Print": elements.Print(); break;
                }
            }
        }
    }
}
