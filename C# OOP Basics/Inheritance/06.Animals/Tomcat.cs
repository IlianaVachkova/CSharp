public class Tomcat : Cat
{
    public Tomcat(string name, string age, string gender)
        : base(name, age, gender)
    {
    }

    public override string PorduceSound()
    {
        return "Give me one million b***h";
    }
}