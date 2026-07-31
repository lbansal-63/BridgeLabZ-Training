using System;

class Vehicle
{
    public static double RegistrationFee = 5000;

    public string OwnerName;
    public string VehicleType;
    public readonly string RegistrationNumber;

    public Vehicle(string ownerName, string vehicleType, string registrationNumber)
    {
        this.OwnerName = ownerName;
        this.VehicleType = vehicleType;
        this.RegistrationNumber = registrationNumber;
    }

    public void Display()
    {
        Console.WriteLine("Owner : " + OwnerName);
        Console.WriteLine("Vehicle : " + VehicleType);
        Console.WriteLine("Registration No : " + RegistrationNumber);
        Console.WriteLine("Fee : " + RegistrationFee);
    }

    public static void UpdateRegistrationFee(double fee)
    {
        RegistrationFee = fee;
    }
}

class Program
{
    static void Main()
    {
        Vehicle.UpdateRegistrationFee(6000);

        Vehicle v = new Vehicle("Amit", "Car", "DL01AB1234");

        if (v is Vehicle)
        {
            v.Display();
        }
    }
}
}