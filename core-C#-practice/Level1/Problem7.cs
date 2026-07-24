using System;

class Program
{
    static void Main()
    {
        double radKm = 6378;
        double volKm = (4/ 3.0) * Math.PI * Math.Pow(radKm, 3);
        double kmToMile = 0.621371;
        double volMile = volumeKm * Math.Pow(kmToMile, 3);

        Console.WriteLine("The volume of earth in cubic kilometers is " + volKm);
        Console.WriteLine("The volume of earth in cubic miles is " + volMile);
    }
}