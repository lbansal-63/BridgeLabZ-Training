using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter c: ");
        int c = Convert.ToDouble(Console.ReadLine());

        double res1 = a + b * c;
        double res2 = a * b + c;
        double res3 = c + a / b;
        double res4 = a % b + c;

        Console.WriteLine("The results of Int Operations are: " + res1 + ", " + res2 + ", " + res3 + ", " + res4);
    }
}
