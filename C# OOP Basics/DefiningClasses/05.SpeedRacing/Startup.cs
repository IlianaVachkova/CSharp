using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Startup
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<Car> cars = new List<Car>();

        for (int i = 0; i < n; i++)
        {
            string[] carInfo = Console.ReadLine().Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries);
            cars.Add(new Car(carInfo[0], double.Parse(carInfo[1]), double.Parse(carInfo[2])));
        }

        string command = Console.ReadLine();
        while (command!="End")
        {
            string[] driveCommandArgs = command.Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries);
            string carModel = driveCommandArgs[1];
            int amountOfKm = int.Parse(driveCommandArgs[2]);
            Car carToDrive = cars.First(c=>c.Model==carModel);
            carToDrive.Drive(amountOfKm);

            command = Console.ReadLine();
        }

        foreach (var car in cars)
        {
            Console.WriteLine("{0} {1:0.00} {2}", car.Model, car.FuelAmount, car.DistanceTraveled);
        }
    }
}
