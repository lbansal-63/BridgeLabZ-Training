using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "This is a damn bad example with some stupid words.";

        string result = Regex.Replace(text,
            @"\b(damn|stupid)\b", "****",
            RegexOptions.IgnoreCase);

        Console.WriteLine(result);
    }
}