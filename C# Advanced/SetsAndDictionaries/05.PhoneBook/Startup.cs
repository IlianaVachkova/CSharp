/*
    Write a program that receives some info from the console about people and their phone numbers.

    You are free to choose the manner in which the data is entered; each entry should have just 
    one name and one number (both of them strings). If you receive a name that already exists in 
    the phonebook, simply update its number.

    After filling this simple phonebook, upon receiving the command "search", and the command “stop”, 
    your program should be able to perform a search of a contact by name and print her details in format 
    "{name} -> {number}". In case the contact isn't found, print "Contact {name} does not exist." Examples:
    
    Input:	                Output:
    Nakov-0888080808        Contact Mariika does not exist.
    search                  Nakov -> 0888080808
    Mariika
    Nakov
    stop	
*/

using System;
using System.Collections.Generic;

public class Startup
{
    public static void Main()
    {
        Dictionary<string, string> phonebook = new Dictionary<string, string>();
        string name = string.Empty;
        string phone = string.Empty;

        string line = Console.ReadLine();

        while (line != "search")
        {
            string[] lineAsArr = line.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            name = lineAsArr[0];
            phone = lineAsArr[1];

            if (!phonebook.ContainsKey(name))
            {
                phonebook.Add(name, phone);
            }

            phonebook[name] = phone;

            line = Console.ReadLine();
        }

        name = Console.ReadLine();
        while (name!="stop")
        {
            if (phonebook.ContainsKey(name))
            {
                phonebook.TryGetValue(name, out phone);
                Console.WriteLine($"{name} -> {phone}");
            }
            else
            {
                Console.WriteLine($"Contact {name} does not exist.");
            }

            name = Console.ReadLine();
        }
    }
}

