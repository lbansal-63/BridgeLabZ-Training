using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string username = "user_123";

        bool valid = Regex.IsMatch(username, @"^[A-Za-z][A-Za-z0-9_]{4,14}$");

        Console.WriteLine(valid ? "Valid" : "Invalid");
    }
}