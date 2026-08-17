using System;

class Program
{
    static int SearchWord(string[] sentences, string target)
    {
        for (int i = 0; i < sentences.Length; i++)
        {
            if (sentences[i].IndexOf(
                target,
                StringComparison.OrdinalIgnoreCase) >= 0)
            {
                return i;
            }
        }

        return -1;
    }

    static void Main()
    {
        string[] sentences =
        {
            "I am learning C#.",
            "C# is an object oriented language.",
            "I like programming.",
            "Searching is important."
        };

        Console.Write("Enter word: ");
        string target = Console.ReadLine();

        int index = SearchWord(sentences, target);

        if (index != -1)
            Console.WriteLine("Found at index: " + index);
        else
            Console.WriteLine("Word not found.");
    }
}