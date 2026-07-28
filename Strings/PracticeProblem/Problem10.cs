using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();

        Console.Write("Enter character to remove: ");
        char remove = Convert.ToChar(Console.ReadLine());

        string result = "";

        foreach (char ch in str)
        {
            if (ch != remove)
                result += ch;
        }

        Console.WriteLine("Modified String: " + result);
    }
}