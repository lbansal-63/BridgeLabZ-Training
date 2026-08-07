using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "This is is a repeated repeated word.";

        MatchCollection matches = Regex.Matches(text,
            @"\b(\w+)\s+\1\b",
            RegexOptions.IgnoreCase);

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Groups[1].Value);
        }
    }
}