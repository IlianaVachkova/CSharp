using System;

public class Dough
{
    private string flourType;
    private string bakingTechnique;
    private double grams;

    public Dough()
    {
    }

    public Dough(string flourType, string bakingTechnique, double grams)
        : this()
    {
        this.FlourType = flourType;
        this.BakingTechnique = bakingTechnique;
        this.Grams = grams;
    }

    public string FlourType
    {
        get
        {
            return this.flourType;
        }

        private set
        {
            if (value != "white" && value != "wholegrain")
            {
                throw new ArgumentException("Invalid type of dough.");
            }

            this.flourType = value;
        }
    }

    public string BakingTechnique
    {
        get
        {
            return this.bakingTechnique;
        }

        private set
        {
            if (value != "crispy" && value != "chewy" && value != "homemade")
            {
                throw new ArgumentException("Invalid type of dough.");
            }

            this.bakingTechnique = value;
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
                throw new ArgumentException("Dough weight should be in the range [1..200].");
            }

            this.grams = value;
        }
    }

    public double GetCaloriesDough()
    {
        return 2 * this.Grams * this.CalculateCaloriesPerGram();
    }

    private double CalculateCaloriesPerGram()
    {
        double result = 1.0;

        switch (this.FlourType)
        {
            case "white": result *= 1.5; break;
            case "wholegrain": result *= 1.0; break;
        }

        switch (this.BakingTechnique)
        {
            case "crispy": result *= 0.9; break;
            case "chewy": result *= 1.1; break;
            case "homemade": result *= 1.0; break;
        }

        return result;
    }
}