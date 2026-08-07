using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "Visit https://www.google.com and http://example.org";

        MatchCollection links = Regex.Matches(text,
            @"https?://[^\s]+");

        foreach (Match link in links)
        {
            Console.WriteLine(link.Value);
        }
    }
}