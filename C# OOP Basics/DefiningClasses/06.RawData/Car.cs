using System.Collections.Generic;

public class Car
{
    private List<Tire> tires;

    public Car(string model, Engine engine, Cargo cargo)
    {
        this.Model = model;
        this.Engine = engine;
        this.Cargo = cargo;
        this.tires = new List<Tire>();
    }

    public string Model { get; private set; }
    public Engine Engine { get; private set; }
    public Cargo Cargo { get; private set; }

    public void AddTire(Tire tire)
    {
        this.tires.Add(tire);
    }
}