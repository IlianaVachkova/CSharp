using System;

public struct Article : IComparable
{
    public string Vendor { get; set; }
    public string Title { get; set; }
    public decimal Price { get; set; }
    public string Barcode { get; set; }

    public Article(string vendor, string title, decimal price, string barcode)
        : this()
    {
        this.Vendor = vendor;
        this.Title = title;
        this.Price = price;
        this.Barcode = barcode;
    }

    public override string ToString()
    {
        return string.Format("Price: {0}, Vendor: {1}, Title: {2}, Barcode: {3}",
            this.Price, this.Vendor, this.Title, this.Barcode);
    }

    public int CompareTo(object obj)
    {
        var other = (Article)obj;
        return this.Price.CompareTo(other.Price);
    }
}