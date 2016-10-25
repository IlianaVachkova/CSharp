using System;
using System.Collections.Generic;

namespace ListyIterator
{
    public class Startup
    {
        public static void Main()
        {
            string line = Console.ReadLine();
            ListyIterator<string> listyIterator = null;

            while (line!="END")
            {
                string[] parameters = line.Split(' ');

                switch (parameters[0])
                {
                    case "Create":
                        if (parameters.Length>1)
                        {
                            List<string> names = new List<string>(parameters);
                            names.RemoveAt(0);
                            listyIterator = new ListyIterator<string>(names);
                        }
                        else
                        {
                            listyIterator = new ListyIterator<string>();
                        }
                        break;
                    case "Move":
                        Console.WriteLine(listyIterator.Move());
                        break;
                    case "HasNext":
                        Console.WriteLine(listyIterator.HasNext());
                        break;
                    case "Print":
                        try
                        {
                            Console.WriteLine(listyIterator.Print());
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                }

                line = Console.ReadLine();
            }
        }
    }
}
