using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<string, int> FindFrequency(List<string> list)
    {
        Dictionary<string, int> frequency =
            new Dictionary<string, int>();

        foreach (string item in list)
        {
            if (frequency.ContainsKey(item))
            {
                frequency[item]++;
            }
            else
            {
                frequency[item] = 1;
            }
        }

        return frequency;
    }

    static void Main()
    {
        List<string> list =
            new List<string> { "apple", "banana", "apple", "orange" };

        Dictionary<string, int> result = FindFrequency(list);

        foreach (var item in result)
        {
            Console.WriteLine(item.Key + " = " + item.Value);
        }
    }
}