using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string color = "#FFA500";

        Console.WriteLine(Regex.IsMatch(color, @"^#[A-Fa-f0-9]{6}$"));
    }
}