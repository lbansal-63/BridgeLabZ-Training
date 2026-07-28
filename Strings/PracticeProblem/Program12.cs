using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();

        Console.Write("Enter word to replace: ");
        string oldWord = Console.ReadLine();

        Console.Write("Enter new word: ");
        string newWord = Console.ReadLine();

        string result = sentence.Replace(oldWord, newWord);

        Console.WriteLine("Updated Sentence:");
        Console.WriteLine(result);
    }
}