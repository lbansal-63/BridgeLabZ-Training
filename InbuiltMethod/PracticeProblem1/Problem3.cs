using System;

class Program
{
    static void Main()
    {
        DateTime currentDate = DateTime.Now;

        Console.WriteLine("Current Date in different formats:");

        // Format: dd/MM/yyyy
        Console.WriteLine(currentDate.ToString("dd/MM/yyyy"));

        // Format: yyyy-MM-dd
        Console.WriteLine(currentDate.ToString("yyyy-MM-dd"));

        // Format: MMM dd, yyyy
        Console.WriteLine(currentDate.ToString("MMM dd, yyyy"));
    }
}