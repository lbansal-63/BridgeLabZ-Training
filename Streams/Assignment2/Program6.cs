using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "data.txt";

        Console.Write("Enter word to search: ");
        string targetWord = Console.ReadLine();

        int count = 0;

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(
                        new char[] { ' ', ',', '.', '!', '?', ';', ':' },
                        StringSplitOptions.RemoveEmptyEntries);

                    foreach (string word in words)
                    {
                        if (word.Equals(targetWord,
                            StringComparison.OrdinalIgnoreCase))
                        {
                            count++;
                        }
                    }
                }
            }

            Console.WriteLine("Word occurred " + count + " times.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("File error: " + ex.Message);
        }
    }
}