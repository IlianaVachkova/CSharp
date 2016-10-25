using System;
using System.Collections.Generic;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        string line = Console.ReadLine();
        List<Cat> cats = new List<Cat>();

        while (line != "End")
        {
            string[] catData = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (catData[0] == "Siamese")
            {
                cats.Add(new Siamese(catData[0], catData[1], int.Parse(catData[2])));
            }
            else if (catData[0] == "Cymric")
            {
                cats.Add(new Cymric(catData[0], catData[1], double.Parse(catData[2])));
            }
            else if (catData[0] == "StreetExtraordinaire")
            {
                cats.Add(new StreetExtraordinaire(catData[0], catData[1], int.Parse(catData[2])));
            }

            line = Console.ReadLine();
        }

        string searchedName = Console.ReadLine();

        var result = cats.Where(c => (c.Name == searchedName)).FirstOrDefault();

        Console.WriteLine(result);
    }
}
