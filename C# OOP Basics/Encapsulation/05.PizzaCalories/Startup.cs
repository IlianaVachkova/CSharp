using System;
using System.Collections.Generic;



public class Pizza
{
    private string name;
    private int numberOfToppings;
    private List<Topping> toppings;

    public Pizza()
    {
    }

    public Pizza(string name, int numberOfToppings)
        : this()
    {
        this.Name = name;
        this.NumberOfToppings = numberOfToppings;
    }

    public Pizza(string name, Dough dough, int numberOfToppings)
        : this(name, numberOfToppings)
    {
        this.Dough = dough;
        this.toppings = new List<Topping>();
    }

    public string Name
    {
        get { return this.name; }
        private set
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length > 15)
            {
                throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
            }

            this.name = value;
        }
    }

    public Dough Dough { get; set; }

    public int NumberOfToppings
    {
        get { return this.numberOfToppings; }
        private set
        {
            if (value < 1 || value > 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }

            this.numberOfToppings = value;
        }
    }

    public double GetTotalCalories()
    {
        double doughCalories = this.Dough.GetCaloriesDough();
        double toppingCalories = 0;
        foreach (var topping in this.toppings)
        {
            toppingCalories += topping.GetCaloriesTopping();
        }

        return doughCalories + toppingCalories;
    }

    public void AddingTopping(Topping topping)
    {
        toppings.Add(topping);
    }
}

public class Startup
{
    public static void Main()
    {
        Dough dough = new Dough();
        Topping topping = new Topping();
        Pizza pizza = new Pizza();
        string nameForEx = string.Empty;

        string input = Console.ReadLine();
        string[] pizzaInfo = input.Split();
        if (pizzaInfo[0].ToLower()=="pizza")
        {
            string pizzaName = pizzaInfo[1];
            int numberOftoppings = int.Parse(pizzaInfo[2]);

            try
            {
                pizza = new Pizza(pizzaName, numberOftoppings);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            string[] doughInfo = Console.ReadLine().Split();
            nameForEx = doughInfo[1];

            try
            {
                dough = new Dough(doughInfo[1].ToLower(), doughInfo[2].ToLower(), double.Parse(doughInfo[3]));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            try
            {
                pizza = new Pizza(pizzaName, dough, numberOftoppings);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            for (int i = 0; i < numberOftoppings; i++)
            {
                string[] toppingInfo = Console.ReadLine().Split();
                nameForEx = toppingInfo[1];

                try
                {
                    topping = new Topping(toppingInfo[1].ToLower(), double.Parse(toppingInfo[2]));
                    pizza.AddingTopping(topping);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(string.Format(ex.Message, nameForEx));
                    return;
                }
            }

            Console.WriteLine(string.Format("{0} - {1:0.00} Calories.", pizza.Name, pizza.GetTotalCalories()));
        }
        else
        {
            while (input!="END")
            {
                string[] pizzaInfo2 = input.Split();

                if (pizzaInfo2[0].ToLower() == "dough")
                {
                    try
                    {
                        dough = new Dough(pizzaInfo2[1].ToLower(), pizzaInfo2[2].ToLower(), double.Parse(pizzaInfo2[3]));
                        Console.WriteLine("{0:0.00}", dough.GetCaloriesDough());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        return;
                    }
                }
                else if (pizzaInfo2[0].ToLower() == "topping")
                {
                    nameForEx = pizzaInfo2[1];

                    try
                    {
                        topping = new Topping(pizzaInfo2[1].ToLower(), double.Parse(pizzaInfo2[2]));
                        Console.WriteLine("{0:0.00}", topping.GetCaloriesTopping());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(string.Format(ex.Message, nameForEx));
                        return;
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}
