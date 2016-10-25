public class StreetExtraordinaire : Cat
{
    public StreetExtraordinaire(string breed, string name, int decibelsOfMeows)
        : base(breed, name)
    {
        this.DecinelsOfMeows = decibelsOfMeows;
    }

    public int DecinelsOfMeows { get; private set; }

    public override string ToString()
    {
        return string.Format("{0} {1}", base.ToString(), this.DecinelsOfMeows);
    }
}