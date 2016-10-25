public class Siamese : Cat
{
    public Siamese(string breed, string name, int earSize)
        : base(breed, name)
    {
        this.EarSize = earSize;
    }

    public int EarSize { get; private set; }

    public override string ToString()
    {
        return string.Format("{0} {1}", base.ToString(), this.EarSize);
    }
}