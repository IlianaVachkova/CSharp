using System.Collections.Generic;

public class Pizza
{
    public static SortedDictionary<int, List<string>> groupedPizza =
        new SortedDictionary<int, List<string>>();

    public Pizza(int group, string name)
    {
        this.Group = group;
        this.Name = name;
    }

    public int Group { get; private set; }

    public string Name { get; private set; }
}