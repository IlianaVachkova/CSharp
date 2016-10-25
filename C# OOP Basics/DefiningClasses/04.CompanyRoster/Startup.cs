using System;
using System.Collections.Generic;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<Employee> employees = new List<Employee>();

        for (int i = 0; i < n; i++)
        {
            string[] lineArr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string name = lineArr[0];
            decimal salary = decimal.Parse(lineArr[1]);
            string position = lineArr[2];
            string department = lineArr[3];

            string email = string.Empty;
            int age = 0;

            if (lineArr.Length == 5)
            {
                if (lineArr[4].IndexOf('@') != -1)
                {
                    email = lineArr[4];

                    employees.Add(new Employee(name, salary, position, department, email));
                }
                else
                {
                    age = int.Parse(lineArr[4]);

                    employees.Add(new Employee(name, salary, position, department, age));
                }
            }
            else if (lineArr.Length == 6)
            {
                email = lineArr[4];
                age = int.Parse(lineArr[5]);
                employees.Add(new Employee(name, salary, position, department, email, age));
            }
            else
            {
                employees.Add(new Employee(name, salary, position, department));
            }
        }

        var result = employees
            .GroupBy(e => e.Department)
            .Select(e => new
            {
                Department = e.Key,
                AverageSalary = e.Average(emp => emp.Salary),
                Employees = e.OrderByDescending(emp => emp.Salary)
            })
            .OrderBy(e => e.AverageSalary)
            .LastOrDefault();

        Console.WriteLine("Highest Average Salary: {0}", result.Department);

        foreach (var employee in result.Employees)
        {
            Console.WriteLine("{0} {1:0.00} {2} {3}", employee.Name, employee.Salary, employee.Email, employee.Age);
        }
    }
}
