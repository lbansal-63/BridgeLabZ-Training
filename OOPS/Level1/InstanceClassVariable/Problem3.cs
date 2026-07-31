using System;

class Vehicle
{
    private string ownerName;
    private string vehicleType;

    private static double registrationFee = 5000;

    public Vehicle(string ownerName, string vehicleType)
    {
        this.ownerName = ownerName;
        this.vehicleType = vehicleType;
    }

    public void DisplayVehicleDetails()
    {
        Console.WriteLine($"{ownerName} | {vehicleType}");
        Console.WriteLine("Fee = " + registrationFee);
    }

    public static void UpdateRegistrationFee(double fee)
    {
        registrationFee = fee;
    }
}