using System;

public class Product : IComparable
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Product(string name, decimal price)
    {
        this.Name = name;
        this.Price = price;
    }

    public override string ToString()
    {
        return string.Format("Name: {0}, Price: {1}",
            this.Name, this.Price);
    }

    public int CompareTo(object obj)
    {
        var other = (Product)obj;
        return this.Price.CompareTo(other.Price);
    }
}