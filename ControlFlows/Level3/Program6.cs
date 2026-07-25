using System;

class Calculator
{
    static void Main()
    {
        double first, second;
        string op;

        Console.Write("Enter first number: ");
        first = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        second = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter operator (+, -, *, /): ");
        op = Console.ReadLine();

        switch (op)
        {
            case "+":
                Console.WriteLine("Result: " + (first + second));
                break;

            case "-":
                Console.WriteLine("Result: " + (first - second));
                break;

            case "*":
                Console.WriteLine("Result: " + (first * second));
                break;

            case "/":
                if (second != 0)
                {
                    Console.WriteLine("Result: " + (first / second));
                }
                else
                {
                    Console.WriteLine("Cannot divide by zero");
                }
                break;

            default:
                Console.WriteLine("Invalid Operator");
                break;
        }
    }
}
