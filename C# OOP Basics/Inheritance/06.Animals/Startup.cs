using System;

public class Startup
{
    public static void Main()
    {
        string animalName = Console.ReadLine();
        string line = Console.ReadLine();
        while (animalName != "Beast!" && line != null)
        {
            string[] animalInfo = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var animal = new Animal();

            try
            {
                switch (animalName.ToLower())
                {
                    case "cat":
                        animal = new Cat(animalInfo[0], animalInfo[1], animalInfo[2]);
                        Console.WriteLine(animalName);
                        Console.WriteLine(animal.ToString());
                        break;
                    case "dog":
                        animal = new Dog(animalInfo[0], animalInfo[1], animalInfo[2]);
                        Console.WriteLine(animalName);
                        Console.WriteLine(animal.ToString());
                        break;
                    case "frog":
                        animal = new Frog(animalInfo[0], animalInfo[1], animalInfo[2]);
                        Console.WriteLine(animalName);
                        Console.WriteLine(animal.ToString());
                        break;
                    case "kitten":
                        animal = new Kitten(animalInfo[0], animalInfo[1], "Female");
                        Console.WriteLine(animalName);
                        Console.WriteLine(animal.ToString());
                        break;
                    case "tomcat":
                        animal = new Tomcat(animalInfo[0], animalInfo[1], "Male");
                        Console.WriteLine(animalName);
                        Console.WriteLine(animal.ToString());
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            animalName = Console.ReadLine();
            line = Console.ReadLine();
        }
    }
}
