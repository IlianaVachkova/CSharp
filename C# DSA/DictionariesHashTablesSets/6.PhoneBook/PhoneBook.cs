using System;
using System.IO;
using System.Linq;
using Wintellect.PowerCollections;

public class PhoneBook
{
    private static MultiDictionary<string, Person> names = new MultiDictionary<string, Person>(true);
    private static MultiDictionary<string, Person> towns = new MultiDictionary<string, Person>(true);

    public static void Main()
    {
        var reader = new StreamReader("..//..//phones.txt");


        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            string[] tokens = line.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
            string name = tokens[0].Trim();
            string town = tokens[1].Trim();
            string phoneNumber = tokens[2].Trim();
            var person = new Person(name, town, phoneNumber);
            names.Add(name, person);
            towns.Add(town, person);
        }

        reader = new StreamReader("..//..//commands.txt");

        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            string[] tokens = line.Split(new char[] { '(' }, StringSplitOptions.RemoveEmptyEntries);
            //string command = tokens[0].Trim();
            string searched = tokens[1].Trim(')');
            string[] searchedItems = searched.Split(new char[] { ',' },
                StringSplitOptions.RemoveEmptyEntries);
            if (searchedItems.Length == 1)
            {
                FindByName(searchedItems[0]);
            }
            else if (searchedItems.Length == 2)
            {
                string name = searchedItems[0].Trim();
                string town = searchedItems[1].Trim();
                FindByNameAndTown(name, town);
            }
        }

        reader.Close();
    }

    private static void FindByName(string name)
    {
        if (names.ContainsKey(name))
        {
            var resultNames = names[name];
            foreach (var item in resultNames)
            {
                Console.WriteLine(item);
            }
        }
    }

    private static void FindByNameAndTown(string name, string town)
    {
        if (names.ContainsKey(name) && towns.ContainsKey(town))
        {
            var resultNames = names[name];
            var resultTowns = towns[town];
            var matchedPeople = resultNames.Intersect(resultTowns);

            foreach (var person in matchedPeople)
            {
                Console.WriteLine(person);
            }
        }
    }
}