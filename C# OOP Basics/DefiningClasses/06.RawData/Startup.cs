using System;
using System.Collections.Generic;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<Car> cars = new List<Car>();

        for (int i = 0; i < n; i++)
        {
            string[] carInfo = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (carInfo[4]== "fragile" && (double.Parse(carInfo[5]) < 1 || double.Parse(carInfo[7]) < 1
                || double.Parse(carInfo[9]) < 1 || double.Parse(carInfo[11]) < 1))
            {
                Car currentCar = new Car(carInfo[0], new Engine(int.Parse(carInfo[1]), int.Parse(carInfo[2])),
                new Cargo(int.Parse(carInfo[3]), carInfo[4]));
                currentCar.AddTire(new Tire(double.Parse(carInfo[5]), int.Parse(carInfo[6])));
                currentCar.AddTire(new Tire(double.Parse(carInfo[7]), int.Parse(carInfo[8])));
                currentCar.AddTire(new Tire(double.Parse(carInfo[9]), int.Parse(carInfo[10])));
                currentCar.AddTire(new Tire(double.Parse(carInfo[11]), int.Parse(carInfo[12])));

                cars.Add(currentCar);
            }

            if (carInfo[4] == "flamable")
            {
                Car currentCar = new Car(carInfo[0], new Engine(int.Parse(carInfo[1]), int.Parse(carInfo[2])),
                new Cargo(int.Parse(carInfo[3]), carInfo[4]));
                currentCar.AddTire(new Tire(double.Parse(carInfo[5]), int.Parse(carInfo[6])));
                currentCar.AddTire(new Tire(double.Parse(carInfo[7]), int.Parse(carInfo[8])));
                currentCar.AddTire(new Tire(double.Parse(carInfo[9]), int.Parse(carInfo[10])));
                currentCar.AddTire(new Tire(double.Parse(carInfo[11]), int.Parse(carInfo[12])));

                cars.Add(currentCar);
            }
        }

        string command = Console.ReadLine();
        List<Car> result = new List<Car>();
        if (command == "fragile")
        {
            result = cars.Where(c => c.Cargo.Type == "fragile").ToList();
        }
        else if (command == "flamable")
        {
            result = cars.Where(c => c.Engine.Power > 250).ToList();
        }

        foreach (var car in result)
        {
            Console.WriteLine("{0}", car.Model);
        }
    }
}
