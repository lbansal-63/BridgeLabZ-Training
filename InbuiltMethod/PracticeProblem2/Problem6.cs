using System;

class Program
{
    static void Main()
    {
        int number = GetNumber();

        long factorial = CalculateFactorial(number);

        DisplayResult(number, factorial);
    }

    static int GetNumber()
    {
        Console.Write("Enter a number: ");
        return int.Parse(Console.ReadLine());
    }

    static long CalculateFactorial(int n)
    {
        if (n == 0 || n == 1)
        {
            return 1;
        }

        return n * CalculateFactorial(n - 1);
    }

    static void DisplayResult(int number, long factorial)
    {
        Console.WriteLine("Factorial of " + number + " is: " + factorial);
    }
}