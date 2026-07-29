using System;

class Program
{
    static void Main()
    {
        int num1 = GetNumber("Enter the first number: ");
        int num2 = GetNumber("Enter the second number: ");

        int gcd = CalculateGCD(num1, num2);
        int lcm = CalculateLCM(num1, num2, gcd);

        Console.WriteLine("GCD = " + gcd);
        Console.WriteLine("LCM = " + lcm);
    }

    static int GetNumber(string message)
    {
        Console.Write(message);
        return int.Parse(Console.ReadLine());
    }

    static int CalculateGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }

        return a;
    }

    static int CalculateLCM(int a, int b, int gcd)
    {
        return (a * b) / gcd;
    }
}