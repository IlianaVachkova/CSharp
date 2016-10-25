/*
    You are given a sequence of strings, each on a new line. Every odd line on the 
    console is representing a resource (e.g. Gold, Silver, Copper, and so on) , and 
    every even – quantity. Your task is to collect the resources and print them each 
    on a new line, unitll you receive “stop” command.

    Print the resources and their quantities in format: {resource} –> {quantity}
    The quantities inputs will be in the range [1 … 2 000 000 000]

    Examples:
    Input:	        Output:
    Gold            Gold -> 155
    155             Silver -> 10
    Silver          Copper -> 17
    10
    Copper
    17
    stop	
*/

using System;
using System.Collections.Generic;

public class Startup
{
    public static void Main()
    {
        Dictionary<string, int> resourceQuantity = new Dictionary<string, int>();
        string resource = Console.ReadLine();
        int quantity = 0; 

        while (resource != "stop")
        {
            quantity = int.Parse(Console.ReadLine());

            if (!resourceQuantity.ContainsKey(resource))
            {
                resourceQuantity.Add(resource, 0);
            }

            resourceQuantity[resource] += quantity;

            resource = Console.ReadLine();
        }

        foreach (var kvp in resourceQuantity)
        {
            Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
        }
    }
}

