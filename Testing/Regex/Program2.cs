using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string plate = "AB1234";

        Console.WriteLine(Regex.IsMatch(plate, @"^[A-Z]{2}[0-9]{4}$"));
    }
}