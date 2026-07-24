using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter c: ");
        int c = Convert.ToInt32(Console.ReadLine());

        int res1 = a + b * c;
        int res2 = a * b + c;
        int res3 = c + a / b;
        int res4 = a % b + c;

        Console.WriteLine("The results of Int Operations are: " + res1 + ", " + res2 + ", " + res3 + ", " + res4);
    }
}
