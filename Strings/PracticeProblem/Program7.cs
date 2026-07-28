using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();

        string result = "";

        foreach (char ch in str)
        {
            if (char.IsUpper(ch))
                result += char.ToLower(ch);
            else if (char.IsLower(ch))
                result += char.ToUpper(ch);
            else
                result += ch;
        }

        Console.WriteLine("Toggled String: " + result);
    }
}