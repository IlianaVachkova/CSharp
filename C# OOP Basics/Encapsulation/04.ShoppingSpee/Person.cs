using System;
using System.Collections.Generic;

public class Person
{
    private string name;
    private decimal money;
    private List<Product> products;

    public Person(string name, decimal money)
    {
        this.Name = name;
        this.Money = money;
        this.products = new List<Product>();
    }

    public string Name
    {
        get
        {
            return this.name;
        }

        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Name cannot be empty");
            }

            this.name = value;
        }
    }

    public decimal Money
    {
        get
        {
            return this.money;
        }

        private set
        {
            if (value < 0.0m)
            {
                throw new ArgumentException("Money cannot be negative");
            }

            this.money = value;
        }

    }

    public void AddProduct(Product product)
    {
        this.products.Add(product);
    }

    public void UpdateMoney(decimal cost)
    {
        this.Money -= cost;
    }

    public List<string> GetProducts()
    {
        List<string> productsName = new List<string>();

        if (this.products.Count != 0)
        {
            foreach (var item in this.products)
            {
                productsName.Add(item.Name);
            }
        }

        return productsName;
    }
}