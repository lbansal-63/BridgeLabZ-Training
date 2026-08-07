using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "I love Java, Python, JavaScript and Go.";

        MatchCollection langs = Regex.Matches(text,
            @"\b(JavaScript|Java|Python|Go)\b");

        foreach (Match lang in langs)
        {
            Console.WriteLine(lang.Value);
        }
    }
}