using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter From City: ");
        string fromCity = Console.ReadLine();

        Console.Write("Enter Via City: ");
        string viaCity = Console.ReadLine();

        Console.Write("Enter Destination City: ");
        string toCity = Console.ReadLine();

        Console.Write("Enter Distance from Start to Via (miles): ");
        double fromToVia = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Distance from Via to Destination (miles): ");
        double viaToFinalCity = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Time Taken (hours): ");
        double timeTaken = Convert.ToDouble(Console.ReadLine());

        double totalDistance = fromToVia + viaToFinalCity;
        double averageSpeed = totalDistance / timeTaken;

        Console.WriteLine("The results of the trip are:");
        Console.WriteLine("Traveler Name: " + name);
        Console.WriteLine("Route: " + fromCity + " -> " + viaCity + " -> " + toCity);
        Console.WriteLine("Total Distance: " + totalDistance + " miles");
        Console.WriteLine("Average Speed: " + averageSpeed + " miles/hour");
    }
}
