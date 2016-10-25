﻿using System;

public class Startup
{
    public static void Main()
    {
        string[] studentInfo = Console.ReadLine().Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);
        string[] workerInfo = Console.ReadLine().Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);

        try
        {
            Student student = new Student(studentInfo[0], studentInfo[1], studentInfo[2]);
            Worker worker = new Worker(workerInfo[0], workerInfo[1], decimal.Parse(workerInfo[2]), decimal.Parse(workerInfo[3]));

            Console.WriteLine(student);
            Console.WriteLine();

            Console.WriteLine(worker);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return;
        }
    }
}
