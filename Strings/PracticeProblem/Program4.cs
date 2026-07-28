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
            if (!result.Contains(ch))
                result += ch;
        }

        Console.WriteLine("After Removing Duplicates: " + result);
    }
}