using System;
using System.IO;

class ImageByteArray
{
    static void Main()
    {
        string sourceImage = "original.jpg";
        string destinationImage = "copy.jpg";

        try
        {
            byte[] imageBytes;

            // Read image into byte array
            using (FileStream input = new FileStream(
                sourceImage, FileMode.Open, FileAccess.Read))
            {
                imageBytes = new byte[input.Length];
                input.ReadExactly(imageBytes);
            }

            // Use MemoryStream
            using (MemoryStream memoryStream = new MemoryStream(imageBytes))
            using (FileStream output = new FileStream(
                destinationImage, FileMode.Create, FileAccess.Write))
            {
                memoryStream.CopyTo(output);
            }

            // Verify files are identical
            byte[] originalBytes = File.ReadAllBytes(sourceImage);
            byte[] copiedBytes = File.ReadAllBytes(destinationImage);

            bool identical = originalBytes.Length == copiedBytes.Length;

            if (identical)
            {
                for (int i = 0; i < originalBytes.Length; i++)
                {
                    if (originalBytes[i] != copiedBytes[i])
                    {
                        identical = false;
                        break;
                    }
                }
            }

            Console.WriteLine("Image copied successfully.");
            Console.WriteLine("Files identical: " + identical);
        }
        catch (IOException ex)
        {
            Console.WriteLine("IO Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}