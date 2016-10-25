using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Startup
{
    public static void Main()
    {
        string[] rawPizzas = Console.ReadLine().Split();

        string pattern = @"(\d+)(\w+)";
        Regex matcher = new Regex(pattern);

        List<Pizza> pizzas = new List<Pizza>();

        for (int i = 0; i < rawPizzas.Length; i++)
        {
            Match match = matcher.Match(rawPizzas[i]);
            Pizza pizza = new Pizza(int.Parse(match.Groups[1].Value), match.Groups[2].Value);
            pizzas.Add(pizza);
        }
    }
}
