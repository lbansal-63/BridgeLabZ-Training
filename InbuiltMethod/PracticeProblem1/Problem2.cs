using System; 
public class Arithmetic
{
    public static void Main()
    {
        Console.Write("Enter a date (dd-MM-YYYY): ");
        DateTime date = DateTime.Parse(Console.ReadLine()); 
        
        DateTime res = date.AddDays(7).AddMonths(1).AddYears(2).AddDays(-21);
        Console.WriteLine($"Orignal Date: {res}");
        Console.WriteLine($"Final Date: {res}");
    }
}