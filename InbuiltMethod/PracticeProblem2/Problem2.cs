using System;

class Program
{
    static void Main()
    {
        int num1 = GetNumber("Enter the first number: ");
        int num2 = GetNumber("Enter the second number: ");
        int num3 = GetNumber("Enter the third number: ");

        int max = FindMaximum(num1, num2, num3);

        Console.WriteLine("The maximum number is: " + max);
    }

    static int GetNumber(string message)
    {
        Console.Write(message);
        return int.Parse(Console.ReadLine());
    }

    static int FindMaximum(int a, int b, int c)
    {
        int max = a;

        if (b > max)
        {
            max = b;
        }

        if (c > max)
        {
            max = c;
        }

        return max;
    }
}