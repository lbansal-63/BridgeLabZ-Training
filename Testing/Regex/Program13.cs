using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "The price is $45.99 and discount is $ 10.50";

        MatchCollection values = Regex.Matches(text,
            @"\$\s?\d+(\.\d{2})?");

        foreach (Match value in values)
        {
            Console.WriteLine(value.Value);
        }
    }
}