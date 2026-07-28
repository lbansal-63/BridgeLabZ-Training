using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine().ToLower();

        int vowels = 0, consonants = 0;

        foreach (char ch in str)
        {
            if (char.IsLetter(ch))
            {
                if ("aeiou".Contains(ch))
                    vowels++;
                else
                    consonants++;
            }
        }

        Console.WriteLine("Vowels: " + vowels);
        Console.WriteLine("Consonants: " + consonants);
    }
}