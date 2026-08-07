using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "The Eiffel Tower is in Paris and the Statue of Liberty is in New York.";

        MatchCollection words = Regex.Matches(text, @"\b[A-Z][a-z]+\b");

        foreach (Match word in words)
        {
            Console.WriteLine(word.Value);
        }
    }
}