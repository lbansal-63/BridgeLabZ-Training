using System;
using System.IO;
using System.Text;

class LowercaseConverter
{
    static void Main()
    {
        string sourceFile = "input.txt";
        string destinationFile = "lowercase.txt";

        try
        {
            using (FileStream inputFile = new FileStream(
                sourceFile, FileMode.Open, FileAccess.Read))
            using (FileStream outputFile = new FileStream(
                destinationFile, FileMode.Create, FileAccess.Write))
            using (BufferedStream bufferedInput =
                new BufferedStream(inputFile))
            using (BufferedStream bufferedOutput =
                new BufferedStream(outputFile))
            using (StreamReader reader =
                new StreamReader(bufferedInput, Encoding.UTF8))
            using (StreamWriter writer =
                new StreamWriter(bufferedOutput, Encoding.UTF8))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    writer.WriteLine(line.ToLowerInvariant());
                }
            }

            Console.WriteLine("Conversion completed successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("IO Error: " + ex.Message);
        }
        catch (DecoderFallbackException ex)
        {
            Console.WriteLine("Encoding error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}