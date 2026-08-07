using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string ssn = "123-45-6789";

        bool valid = Regex.IsMatch(ssn,
            @"^\d{3}-\d{2}-\d{4}$");

        Console.WriteLine(valid ? "Valid" : "Invalid");
    }
}