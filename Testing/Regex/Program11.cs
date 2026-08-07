using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string card = "4123456789012345";

        bool valid = Regex.IsMatch(card,
            @"^(4|5)\d{15}$");

        Console.WriteLine(valid);
    }
}