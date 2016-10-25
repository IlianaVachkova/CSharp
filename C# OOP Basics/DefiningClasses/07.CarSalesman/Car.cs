public class Car
{
    public Car(string model, Engine engine)
    {
        this.Model = model;
        this.EngineCar = engine;
        this.Color = "n/a";
    }

    public Car(string model, Engine engine, int weight)
        : this(model, engine)
    {
        this.Weight = weight;
    }

    public Car(string model, Engine engine, string color)
        : this(model, engine)
    {
        this.Color = color;
    }

    public Car(string model, Engine engine, int weight, string color)
        : this(model, engine)
    {
        this.Weight = weight;
        this.Color = color;
    }

    public string Model { get; private set; }
    public Engine EngineCar { get; set; }
    public int Weight { get; private set; }
    public string Color { get; private set; }
}
