using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter Side 1 (meters): ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Side 2 (meters): ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Side 3 (meters): ");
        double side3 = Convert.ToDouble(Console.ReadLine());

        double perimeter = side1 + side2 + side3;

        double rounds = 5000 / perimeter;

        Console.WriteLine("The total number of rounds the athlete will run is " + rounds + " to complete 5 km");
    }
}
