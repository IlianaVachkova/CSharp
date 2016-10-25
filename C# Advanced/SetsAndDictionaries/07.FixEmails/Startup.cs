/*
    You are given a sequence of strings, each on a new line, unitll you receive “stop” 
    command. First string is a name of a person. On the second line you receive his email. 
    Your task is to collect their names and emails, and remove emails whose domain ends with 
    "us" or "uk" (case insensitive). 
        Print: {name} – > {email}

      Input	:                           Output:
      Ivan                              Ivan -> ivanivan@abv.bg
      ivanivan@abv.bg                   Petar Ivanov -> petartudjarov@abv.bg
      Petar Ivanov
      petartudjarov@abv.bg
      Mike Tyson
      myke@gmail.us
      stop	
*/

using System;
using System.Collections.Generic;

public class Startup
{
    public static void Main()
    {
        string name = Console.ReadLine();
        string email = string.Empty;
        Dictionary<string, string> nameEmail = new Dictionary<string, string>();

        while (name != "stop")
        {
            email = Console.ReadLine();
            string test = email.Substring(email.Length - 2, 2);

            if (email.Substring(email.Length - 2, 2) != "uk" && email.Substring(email.Length - 2, 2) != "us")
            {
                if (!nameEmail.ContainsKey(name))
                {
                    nameEmail.Add(name, email);
                }
            }

            name = Console.ReadLine();
        }

        foreach (var kvp in nameEmail)
        {
            Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
        }
    }
}
