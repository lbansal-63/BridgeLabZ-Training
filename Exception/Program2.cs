using System;

public class Program2
{
    public static void Main()
    {
        int num;
        Console.Write("Enter the number: ");
        num = Convert.ToInt32(Console.ReadLine());

        int div;
        Console.Write("Enter the divisor: ");
        div = Convert.ToInt32(Console.ReadLine());

        try
        {
            int res = num / div;
            Console.WriteLine("Result: {0}", res); // Divide by zero exception

        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("You cannot divide a number by zero.");
            Console.WriteLine(ex.Message); 
        }

        Console.WriteLine("Remaining statements1");
        Console.WriteLine("Remaining statements2");
        Console.WriteLine("Remaining statements3");
    }
}