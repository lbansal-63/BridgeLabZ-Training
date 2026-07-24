using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int quot = num1 / num2;
        int rem = num1 % num2;

        Console.WriteLine("The Quotient is "+quot" and Remainder is "+rem+" of two numbers"+num1+" and "+num2);
    }
}
