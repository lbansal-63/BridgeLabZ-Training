using System;

class Program
{
    static void Main()
    {
        double disInFeet;

        Console.Write("Enter distance in feet: ");
        disInFeet = Convert.ToDouble(Console.ReadLine());

        double disInYards = disInFeet / 3;

        double disInMiles = disInYards / 1760;

        Console.WriteLine("The distance in feet is " + disInFeet + ", in yards is " + disInYards + " and in miles is " + disInMiles);
    }
}
