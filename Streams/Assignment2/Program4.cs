using System;
using System.Diagnostics;
using System.Text;

class Program
{
    static void Main()
    {
        int count = 100000;

        // Using string +
        Stopwatch stopwatch = new Stopwatch();

        stopwatch.Start();

        string result1 = "";

        for (int i = 0; i < count; i++)
        {
            result1 += i;
        }

        stopwatch.Stop();

        Console.WriteLine("String concatenation: " +
                          stopwatch.ElapsedMilliseconds + " ms");

        // Using StringBuilder
        stopwatch.Restart();

        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < count; i++)
        {
            sb.Append(i);
        }

        string result2 = sb.ToString();

        stopwatch.Stop();

        Console.WriteLine("StringBuilder: " +
                          stopwatch.ElapsedMilliseconds + " ms");
    }
}