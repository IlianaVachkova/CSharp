public class Cymric : Cat
{
    public Cymric(string breed, string name, double furLength)
        : base(breed, name)
    {
        this.FurLength = furLength;
    }

    public double FurLength { get; private set; }

    public override string ToString()
    {
        return string.Format("{0} {1:0.00}", base.ToString(), this.FurLength);
    }
}