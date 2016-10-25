using System;
using System.Collections.Generic;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        List<Car> cars = new List<Car>();
        List<Engine> engines = new List<Engine>();

        int numOfEngines = int.Parse(Console.ReadLine());
        for (int i = 0; i < numOfEngines; i++)
        {
            string[] engineInfo = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (engineInfo.Length == 2)
            {
                engines.Add(new Engine(engineInfo[0], int.Parse(engineInfo[1])));
            }
            else if (engineInfo.Length == 3)
            {
                int n;
                if (int.TryParse(engineInfo[2], out n))
                {
                    engines.Add(new Engine(engineInfo[0], int.Parse(engineInfo[1]), int.Parse(engineInfo[2])));
                }
                else
                {
                    engines.Add(new Engine(engineInfo[0], int.Parse(engineInfo[1]), engineInfo[2]));
                }
            }
            else if (engineInfo.Length == 4)
            {
                engines.Add(new Engine(engineInfo[0], int.Parse(engineInfo[1]), int.Parse(engineInfo[2]), engineInfo[3]));
            }
        }

        int numOfCars = int.Parse(Console.ReadLine());
        for (int i = 0; i < numOfCars; i++)
        {
            string[] carInfo = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (carInfo.Length == 2)
            {
                cars.Add(new Car(carInfo[0], new Engine(carInfo[1])));
            }
            else if (carInfo.Length == 3)
            {
                int n;
                if (int.TryParse(carInfo[2], out n))
                {
                    cars.Add(new Car(carInfo[0], new Engine(carInfo[1]), int.Parse(carInfo[2])));
                }
                else
                {
                    cars.Add(new Car(carInfo[0], new Engine(carInfo[1]), carInfo[2]));
                }
            }
            else if (carInfo.Length == 4)
            {
                cars.Add(new Car(carInfo[0], new Engine(carInfo[1]), int.Parse(carInfo[2]), carInfo[3]));
            }
        }

        foreach (var car in cars)
        {
            Console.WriteLine(string.Format("{0}:\n  {1}:", car.Model, car.EngineCar.Model));

            var currentEngine = engines.Where(e => e.Model == car.EngineCar.Model).FirstOrDefault();

            string displacement = "n/a";
            if (currentEngine.Displacement != 0)
            {
                displacement = currentEngine.Displacement.ToString();
            }

            Console.WriteLine(string.Format("   Power: {0}\n   Displacement: {1}\n   Efficiency: {2}",
                currentEngine.Power, displacement, currentEngine.Efficiency));

            string weight = "n/a";
            if (car.Weight != 0)
            {
                weight = car.Weight.ToString();
            }

            Console.WriteLine(string.Format("  Weight: {0}\n  Color: {1}", weight, car.Color));
        }
    }
}
