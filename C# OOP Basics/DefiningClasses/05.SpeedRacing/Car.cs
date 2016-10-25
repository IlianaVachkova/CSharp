using System;

public class Car
{
    public Car(string model, double fuelAmount, double fuelCostFor1km)
    {
        this.Model = model;
        this.FuelAmount = fuelAmount;
        this.FuelCostFor1km = fuelCostFor1km;
        this.DistanceTraveled = 0;
    }

    public string Model { get; private set; }
    public double FuelAmount { get; private set; }
    public double FuelCostFor1km { get; private set; }
    public double DistanceTraveled { get; private set; }

    public void Drive(int amountOfKilometers)
    {
        if (amountOfKilometers <= this.FuelAmount / this.FuelCostFor1km)
        {
            this.DistanceTraveled += amountOfKilometers;
            this.FuelAmount -= (this.FuelCostFor1km * amountOfKilometers);
        }
        else
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
    }
}