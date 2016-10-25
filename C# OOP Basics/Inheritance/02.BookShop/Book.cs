using System;
using System.Text;

public class Book
{
    private string title;
    private string author;
    private double price;

    public Book(string author, string title, double price)
    {
        this.Author = author;
        this.Title = title;
        this.Price = price;
    }

    public string Title
    {
        get
        {
            return this.title;
        }

        set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Title not valid!");
            }

            this.title = value;
        }
    }

    public string Author
    {
        get
        {
            return this.author;
        }

        set
        {
            string[] names = value.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (names.Length > 1)
            {
                if ((names[1][0] >= 48 && names[1][0] <= 57) || string.IsNullOrWhiteSpace(names[0]))
                {
                    throw new ArgumentException("Author not valid!");
                }
            }

            this.author = value;
        }
    }

    public virtual double Price
    {
        get
        {
            return this.price;
        }

        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Price not valid!");
            }

            this.price = value;
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("Type: ").Append(this.GetType().Name)
                .Append(Environment.NewLine)
                .Append("Title: ").Append(this.Title)
                .Append(Environment.NewLine)
                .Append("Author: ").Append(this.Author)
                .Append(Environment.NewLine)
                .Append("Price: ").AppendFormat("{0:0.0}", this.Price)
                .Append(Environment.NewLine);

        return sb.ToString();
    }
}