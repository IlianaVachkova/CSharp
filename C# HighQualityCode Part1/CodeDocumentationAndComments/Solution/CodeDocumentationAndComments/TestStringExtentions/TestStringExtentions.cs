using System;
using Telerik.ILS.Common;

public class TestStringExtensions
{
    public static void Main()
    {
        string input = "a34";
        int intValue = input.ToShort();
        DateTime dateTime = input.ToDateTime();
        byte[] byteArray = input.ToByteArray();
        Console.WriteLine(string.Join(" ", byteArray));
        Console.WriteLine(input.ToMd5Hash());
    }
}