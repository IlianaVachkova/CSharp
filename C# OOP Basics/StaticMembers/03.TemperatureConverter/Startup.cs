using System;

public class Startup
{
    public static string TempConverter(int temperature, string unit)
    {
        string result = string.Empty;
        double convertedTemp = 0.0;

        if (unit == "Celsius")
        {
            convertedTemp = (temperature * 9.0) / 5.0 + 32;
            unit = "Fahrenheit";
            result = string.Format("{0:0.00} {1}", convertedTemp, unit);
        }
        else if (unit == "Fahrenheit")
        {
            convertedTemp = 5.0 / 9.0 * (temperature - 32);
            unit = "Celsius";
            result = string.Format("{0:0.00} {1}", convertedTemp, unit);
        }

        return result;
    }

    public static void Main()
    {
        string line = Console.ReadLine();
        while (line != "End")
        {
            string[] lineArr = line.Split();
            Console.WriteLine(TempConverter(int.Parse(lineArr[0]), lineArr[1]));

            line = Console.ReadLine();
        }
    }
}
