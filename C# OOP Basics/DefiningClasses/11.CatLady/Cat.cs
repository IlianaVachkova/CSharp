public class Cat
{
    public Cat(string breed, string name)
    {
        this.Breed = breed;
        this.Name = name;
    }

    public string Breed { get; private set; }
    public string Name { get; private set; }

    public override string ToString()
    {
        return this.Breed + " " + this.Name;
    }
}