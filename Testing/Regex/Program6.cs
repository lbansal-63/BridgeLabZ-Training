using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "12/05/2023 15/08/2024 29/02/2020";

        MatchCollection dates = Regex.Matches(text,
            @"\b\d{2}/\d{2}/\d{4}\b");

        foreach (Match date in dates)
        {
            Console.WriteLine(date.Value);
        }
    }
}