using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter the first date (yyyy-MM-dd): ");
        DateTime date1 = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter the second date (yyyy-MM-dd): ");
        DateTime date2 = DateTime.Parse(Console.ReadLine());

        int result = DateTime.Compare(date1, date2);

        if (result < 0)
        {
            Console.WriteLine("The first date is before the second date.");
        }
        else if (result > 0)
        {
            Console.WriteLine("The first date is after the second date.");
        }
        else
        {
            Console.WriteLine("Both dates are the same.");
        }
    }
}