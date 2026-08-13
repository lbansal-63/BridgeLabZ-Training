using System;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Regular Expression (Regex) in C#: ");
        Console.WriteLine("-----------------------------------");

        string myText = "b";
        string pattern = @"^[a-f]$";

        // option 1
        Regex obj = new Regex(pattern);
        bool IsMatch1 = obj.IsMatch(myText);
        Console.WriteLine($"myText: {myText}, pattern: {pattern}");
        Console.WriteLine($"Valid Text using non-static method: {IsMatch1}");

        // option 2
        bool IsMatch2 = Regex.IsMatch(myText,pattern);
        Console.WriteLine($"myText: {myText}, pattern: {pattern}"); 
        Console.WriteLine($"Valid Text using static method: {IsMatch2}"); 
        Console.ReadLine(); 
    }
}