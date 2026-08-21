using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = num1 / num2;

            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter valid numbers.");
        }
    }
}