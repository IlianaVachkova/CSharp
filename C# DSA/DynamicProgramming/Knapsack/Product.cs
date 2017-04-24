public struct Product
{
    public string Name { get; set; }
    public int Weight { get; set; }
    public int Cost { get; set; }

    public Product(string name, int weight, int cost)
        : this()
    {
        this.Name = name;
        this.Weight = weight;
        this.Cost = cost;
    }

    public override string ToString()
    {
        return string.Format("Product: {0}, Weight: {1}kg, Cost: ${2}", 
            this.Name, this.Weight, this.Cost);
    }
}