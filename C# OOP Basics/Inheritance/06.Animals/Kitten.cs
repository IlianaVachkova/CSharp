public class Kitten : Cat
{
    public Kitten(string name, string age, string gender)
        : base(name, age, gender)
    {
    }

    public override string PorduceSound()
    {
        return "Miau";
    }
}