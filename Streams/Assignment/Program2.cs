using System;
using System.Diagnostics;
using System.IO;

class BufferedFileCopy
{
    static void CopyWithoutBuffer(string source, string destination)
    {
        byte[] buffer = new byte[4096];

        using (FileStream input = new FileStream(
            source, FileMode.Open, FileAccess.Read))
        using (FileStream output = new FileStream(
            destination, FileMode.Create, FileAccess.Write))
        {
            int bytesRead;

            while ((bytesRead = input.Read(buffer, 0, buffer.Length)) > 0)
            {
                output.Write(buffer, 0, bytesRead);
            }
        }
    }

    static void CopyWithBuffer(string source, string destination)
    {
        byte[] buffer = new byte[4096];

        using (FileStream inputFile = new FileStream(
            source, FileMode.Open, FileAccess.Read))
        using (FileStream outputFile = new FileStream(
            destination, FileMode.Create, FileAccess.Write))
        using (BufferedStream input = new BufferedStream(inputFile))
        using (BufferedStream output = new BufferedStream(outputFile))
        {
            int bytesRead;

            while ((bytesRead = input.Read(buffer, 0, buffer.Length)) > 0)
            {
                output.Write(buffer, 0, bytesRead);
            }
        }
    }

    static void Main()
    {
        string source = "largefile.dat";
        string normalCopy = "normal_copy.dat";
        string bufferedCopy = "buffered_copy.dat";

        try
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            CopyWithoutBuffer(source, normalCopy);
            stopwatch.Stop();

            long normalTime = stopwatch.ElapsedMilliseconds;

            stopwatch.Reset();

            stopwatch.Start();
            CopyWithBuffer(source, bufferedCopy);
            stopwatch.Stop();

            long bufferedTime = stopwatch.ElapsedMilliseconds;

            Console.WriteLine("Normal FileStream Time: " +
                              normalTime + " ms");

            Console.WriteLine("BufferedStream Time: " +
                              bufferedTime + " ms");

            if (bufferedTime < normalTime)
                Console.WriteLine("BufferedStream is faster.");
            else
                Console.WriteLine("Normal FileStream was faster.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("IO Error: " + ex.Message);
        }
    }
}