using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.Write("Enter email address: ");
        string email = Console.ReadLine();

        string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

        if (Regex.IsMatch(email, pattern))
        {
            Console.WriteLine("Valid email address");
        }
        else
        {
            Console.WriteLine("Invalid email address");
        }
    }
}