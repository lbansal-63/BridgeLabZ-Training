using System;
public class Program10
{
    public static void Chocolate(int n, int m)
    {
        int num = n / m;
        int rem = n % m;

        Console.WriteLine("the number of chocolates each child will get: " + num);
        Console.WriteLine("Remaining Chocolates: " + rem);
    }

    public static void Main()
    {
        int n;
        Console.Write("Enter the number of chocolates: ");
        n = Convert.ToInt32(Console.ReadLine());

        int m;
        Console.Write("Enter the number of children: ");
        m = Convert.ToInt32(Console.ReadLine());

        Program10.Chocolate(n, m);

    }
}