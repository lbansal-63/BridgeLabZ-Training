using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<int, List<string>> Invert(
        Dictionary<string, int> input)
    {
        Dictionary<int, List<string>> result =
            new Dictionary<int, List<string>>();

        foreach (var item in input)
        {
            string key = item.Key;
            int value = item.Value;

            if (!result.ContainsKey(value))
            {
                result[value] =
                    new List<string>();
            }

            result[value].Add(key);
        }

        return result;
    }

    static void Main()
    {
        Dictionary<string, int> input =
            new Dictionary<string, int>
            {
                { "A", 1 },
                { "B", 2 },
                { "C", 1 }
            };

        Dictionary<int, List<string>> result =
            Invert(input);

        foreach (var item in result)
        {
            Console.WriteLine(
                item.Key + " = " +
                string.Join(", ", item.Value));
        }
    }
}