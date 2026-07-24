using System;

class Program
{
    static void Main()
    {
        double km;

        Console.Write("Enter distance in km: ");
        km = Convert.ToDouble(Console.ReadLine());

        double miles = km / 1.6;

        Console.WriteLine("The total miles is " + miles + " mile for the given " + km + " km");
    }
}
