using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static Dictionary<string, int> WordFrequency(string text)
    {
        Dictionary<string, int> result =
            new Dictionary<string, int>(
                StringComparer.OrdinalIgnoreCase);

        char[] separators =
        {
            ' ', ',', '.', '!', '?', ';', ':'
        };

        string[] words =
            text.Split(
                separators,
                StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in words)
        {
            string cleanWord = word.ToLower();

            if (result.ContainsKey(cleanWord))
            {
                result[cleanWord]++;
            }
            else
            {
                result[cleanWord] = 1;
            }
        }

        return result;
    }

    static void Main()
    {
        string text =
            "Hello world, hello Java!";

        Dictionary<string, int> result =
            WordFrequency(text);

        foreach (var item in result)
        {
            Console.WriteLine(
                item.Key + " = " + item.Value);
        }
    }
}