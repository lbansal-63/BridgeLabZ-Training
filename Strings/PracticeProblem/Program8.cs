using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first string: ");
        string s1 = Console.ReadLine();

        Console.Write("Enter second string: ");
        string s2 = Console.ReadLine();

        int min = Math.Min(s1.Length, s2.Length);
        bool printed = false;

        for (int i = 0; i < min; i++)
        {
            if (s1[i] < s2[i])
            {
                Console.WriteLine($"{s1} comes before {s2}");
                printed = true;
                break;
            }
            else if (s1[i] > s2[i])
            {
                Console.WriteLine($"{s2} comes before {s1}");
                printed = true;
                break;
            }
        }

        if (!printed)
        {
            if (s1.Length < s2.Length)
                Console.WriteLine($"{s1} comes before {s2}");
            else if (s1.Length > s2.Length)
                Console.WriteLine($"{s2} comes before {s1}");
            else
                Console.WriteLine("Both strings are equal.");
        }
    }
}