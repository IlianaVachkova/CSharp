using System;

namespace ThreeupleImplementation
{
    public class Startup
    {
        public static void Main()
        {
            string[] personInput = Console.ReadLine().Split();
            string fullName = personInput[0] + " " + personInput[1];
            string address = personInput[2];
            string town = personInput[3];
            Treuple<string, string, string> person = new Treuple<string, string, string>(fullName, address, town);
            Console.WriteLine(person);

            string[] beerInput = Console.ReadLine().Split();
            string beerName = beerInput[0];
            int beerLiters = int.Parse(beerInput[1]);
            bool beerDrunk = beerInput[2] == "drunk";
            Treuple<string, int, bool> beer = new Treuple<string, int, bool>(beerName, beerLiters, beerDrunk);
            Console.WriteLine(beer);

            string[] bankInput = Console.ReadLine().Split();
            string bankPersonName = bankInput[0];
            double bankAccountBalance = double.Parse(bankInput[1]);
            string bankName = bankInput[2];
            Treuple<string, double, string> bank = new Treuple<string, double, string>(bankPersonName, bankAccountBalance, bankName);
            Console.WriteLine(bank);
        }
    }
}
