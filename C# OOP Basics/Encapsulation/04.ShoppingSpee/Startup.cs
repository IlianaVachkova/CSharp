using System;
using System.Collections.Generic;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        List<Person> people = new List<Person>();
        string[] peopleInput = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < peopleInput.Length; i++)
        {
            string[] personInfo = peopleInput[i].Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
            if (personInfo.Length == 1)
            {
                Console.WriteLine("Name cannot be empty");
                return;
            }

            try
            {
                Person currentPerson = new Person(personInfo[0], decimal.Parse(personInfo[1]));
                people.Add(currentPerson);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }

        List<Product> products = new List<Product>();
        string[] productsInput = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < productsInput.Length; i++)
        {
            string[] productInfo = productsInput[i].Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
            if (productInfo.Length == 1)
            {
                Console.WriteLine("Name cannot be empty");
                return;
            }

            try
            {
                Product currentProduct = new Product(productInfo[0], decimal.Parse(productInfo[1]));
                products.Add(currentProduct);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

        }

        string line = Console.ReadLine();
        while (line != "END")
        {
            string[] lineArr = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Person currentPerson = people.FirstOrDefault(p => p.Name == lineArr[0]);
            Product currentProduct = products.FirstOrDefault(p => p.Name == lineArr[1]);

            if (currentPerson.Money >= currentProduct.Cost)
            {
                currentPerson.AddProduct(currentProduct);
                currentPerson.UpdateMoney(currentProduct.Cost);

                Console.WriteLine("{0} bought {1}", currentPerson.Name, currentProduct.Name);
            }
            else
            {
                Console.WriteLine("{0} can't afford {1}", currentPerson.Name, currentProduct.Name);
            }

            line = Console.ReadLine();
        }

        foreach (var person in people)
        {
            if (person.GetProducts().Count == 0)
            {
                Console.WriteLine("{0} - Nothing bought", person.Name);
            }
            else
            {
                Console.WriteLine("{0} - {1}", person.Name, string.Join(", ", person.GetProducts()));
            }
        }
    }
}
