using System;

namespace _1.ProspectInHospitality
{
    public class Startup
    {
        public static void Main()
        {
            uint amountBuildersNeeded = uint.Parse(Console.ReadLine());
            uint amountReceptionistsNeeded = uint.Parse(Console.ReadLine());
            uint amoundChambermaindsNeeded = uint.Parse(Console.ReadLine());
            uint amountTechnitiansNeeded = uint.Parse(Console.ReadLine());
            uint amountOtherStuffNeeded = uint.Parse(Console.ReadLine());

            decimal nikiSalary = decimal.Parse(Console.ReadLine());
            decimal currencyRate = decimal.Parse(Console.ReadLine());
            decimal yourSalary = decimal.Parse(Console.ReadLine());
            decimal budget = decimal.Parse(Console.ReadLine());

            decimal amount;

            amount = amountBuildersNeeded * (decimal)1500.04 + amountReceptionistsNeeded * (decimal)2102.10 
                + amoundChambermaindsNeeded * (decimal)1465.46 + amountTechnitiansNeeded * (decimal)2053.33 
                + amountOtherStuffNeeded * (decimal)3010.98 + nikiSalary * currencyRate + yourSalary;

            if (budget>=amount)
            {
                Console.WriteLine("The amount is: {0:0.00} lv.", amount);
                Console.WriteLine("YES \\ Left: {0:0.00} lv.", (budget-amount));
            }
            else if (budget<amount)
            {
                Console.WriteLine("The amount is: {0:0.00} lv.", amount);
                Console.WriteLine("NO \\ Need more: {0:0.00} lv.", amount-budget);
            }
        }
    }
}
