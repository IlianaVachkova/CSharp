public class Engine
{
    public Engine(string model)
    {
        this.Model = model;
        this.Efficiency = "n/a";
    }

    public Engine(string model, int power)
        : this(model)
    {
        this.Power = power;
    }

    public Engine(string model, int power, int displacement)
        : this(model, power)
    {
        this.Displacement = displacement;
    }

    public Engine(string model, int power, string efficiency)
        : this(model, power)
    {
        this.Efficiency = efficiency;
    }

    public Engine(string model, int power, int displacement, string efficiency)
        : this(model, power)
    {
        this.Displacement = displacement;
        this.Efficiency = efficiency;
    }

    public string Model { get; private set; }
    public int Power { get; private set; }
    public int Displacement { get; private set; }
    public string Efficiency { get; private set; }
}
