using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter Number of Chocolates: ");
        int chocolates = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Number of Children: ");
        int child = Convert.ToInt32(Console.ReadLine());

        int eachGets = chocolates / child;
        int remaining = chocolates % child;

        Console.WriteLine("The number of chocolates each child gets is " + eachGets + " and the number of remaining chocolates is " + remaining);
    }
}
