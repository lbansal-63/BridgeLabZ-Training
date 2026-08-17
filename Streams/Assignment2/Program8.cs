using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "output.txt";

        Console.Write("Enter text: ");
        string input = Console.ReadLine();

        try
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(input);
            }

            Console.WriteLine("Data written successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("File error: " + ex.Message);
        }
    }
}