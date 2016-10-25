using System;

public class Topping
{
    private string type;
    private double grams;

    public Topping()
    {
    }

    public Topping(string type, double grams)
        : this()
    {
        this.Type = type;
        this.Grams = grams;
    }

    public string Type
    {
        get
        {
            return this.type;
        }

        private set
        {
            if (value != "meat" && value != "chewy" && value != "veggies" && value != "cheese" && value != "sauce")
            //&& value != "Meat" && value != "Chewy" && value != "Veggies" && value != "Cheese" && value != "Sauce")
            {
                throw new ArgumentException("Cannot place {0} on top of your pizza.");
            }

            this.type = value;
        }
    }

    public double Grams
    {
        get
        {
            return this.grams;
        }

        private set
        {
            if (value < 1 || value > 200)
            {
                throw new ArgumentException("{0} weight should be in the range [1..50].");
            }

            this.grams = value;
        }
    }

    public double GetCaloriesTopping()
    {
        return 2 * this.Grams * this.CalculateCaloriesPerGram();
    }

    private double CalculateCaloriesPerGram()
    {
        double result = 1.0;

        switch (this.type)
        {
            case "meat":
                //case "Meat":
                result *= 1.2;
                break;
            case "veggies":
                //case "Veggies":
                result *= 0.8;
                break;
            case "cheese":
                //case "Cheese":
                result *= 1.1;
                break;
            case "sauce":
                //case "Sauce":
                result *= 0.9;
                break;
        }

        return result;
    }
}