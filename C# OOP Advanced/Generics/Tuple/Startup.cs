using System;

namespace TupleImplementation
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            string[] personInput = Console.ReadLine().Split();
            string firstName = personInput[0];
            string lastName = personInput[1];
            string fullName = firstName + " " + lastName;
            string address = personInput[2];
            Tuple<string, string> person = new Tuple<string, string>(fullName, address);
            Console.WriteLine(person);

            string[] beerInput = Console.ReadLine().Split();
            string beerName = beerInput[0];
            int beerLiters = int.Parse(beerInput[1]);
            Tuple<string, int> beer = new Tuple<string, int>(beerName, beerLiters);
            Console.WriteLine(beer);

            string[] sampleTupleInput = Console.ReadLine().Split();
            int sampleInt = int.Parse(sampleTupleInput[0]);
            double sampleDouble = double.Parse(sampleTupleInput[1]);
            Tuple<int, double> sample = new Tuple<int, double>(sampleInt, sampleDouble);
            Console.WriteLine(sample);
        }
    }
}
