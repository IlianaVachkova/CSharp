/*
    A company has name, address, phone number, fax number, web site and manager. 
    The manager has first name, last name, age and a phone number.
    Write a program that reads the information about a company and its manager 
    and prints it back on the console.
*/

using System;

public class Startup
{
    static void Main()
    {
        string companyName = Console.ReadLine();
        string companyAddress = Console.ReadLine();
        string phoneNumber = Console.ReadLine();
        string faxNumber = Console.ReadLine();
        string webSite = Console.ReadLine();
        string managerFirstName = Console.ReadLine();
        string managerLastName = Console.ReadLine();
        byte managerAge = byte.Parse(Console.ReadLine());
        string managerPhone = Console.ReadLine();
        Console.WriteLine(companyName);
        Console.WriteLine("Address: {0}", companyAddress);
        Console.WriteLine("Tel. {0}", phoneNumber);

        if (faxNumber==String.Empty)
        {
            faxNumber = "(no fax)";
        }
        Console.WriteLine("Fax: {0}", faxNumber);
        Console.WriteLine("Web site: {0}", webSite);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", managerFirstName, managerLastName, managerAge,managerPhone );
    }
}

