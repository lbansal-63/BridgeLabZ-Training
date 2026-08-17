using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        string filePath = "data.txt";

        try
        {
            using (FileStream fileStream = new FileStream(
                filePath,
                FileMode.Open,
                FileAccess.Read))
            {
                using (StreamReader reader = new StreamReader(
                    fileStream,
                    Encoding.UTF8))
                {
                    int character;

                    while ((character = reader.Read()) != -1)
                    {
                        Console.Write((char)character);
                    }
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("File error: " + ex.Message);
        }
    }
}