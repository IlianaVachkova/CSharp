using System;

public class Startup
{
    public static void Main()
    {
        string line = Console.ReadLine();
        while (line != "End")
        {
            string[] lineAsArr = line.Split();
            string action = lineAsArr[0];

            switch (action)
            {
                case "Sum":
                    Console.WriteLine("{0:0.00}", MathUtil.Sum(double.Parse(lineAsArr[1]), double.Parse(lineAsArr[2])));
                    break;
                case "Multiply":
                    Console.WriteLine("{0:0.00}", MathUtil.Multiply(double.Parse(lineAsArr[1]), double.Parse(lineAsArr[2])));
                    break;
                case "Percentage":
                    Console.WriteLine("{0:0.00}", MathUtil.Percentage(double.Parse(lineAsArr[1]), double.Parse(lineAsArr[2])));
                    break;
                case "Divide":
                    Console.WriteLine("{0:0.00}", MathUtil.Divide(double.Parse(lineAsArr[1]), double.Parse(lineAsArr[2])));
                    break;
                case "Subtract":
                    Console.WriteLine("{0:0.00}", MathUtil.Subtract(double.Parse(lineAsArr[1]), double.Parse(lineAsArr[2])));
                    break;
            }

            line = Console.ReadLine();
        }
    }
}
