using System;
using System.Collections.Generic;

// Interface
interface IGPS
{
    void GetCurrentLocation();
    void UpdateLocation(string location);
}

// Abstract Class
abstract class Vehicle
{
    // Encapsulation
    private int vehicleId;
    private string driverName;
    private double ratePerKm;

    // Properties
    public int VehicleId
    {
        get { return vehicleId; }
        set { vehicleId = value; }
    }

    public string DriverName
    {
        get { return driverName; }
        set { driverName = value; }
    }

    public double RatePerKm
    {
        get { return ratePerKm; }
        set { ratePerKm = value; }
    }

    // Constructor
    public Vehicle(int id, string driver, double rate)
    {
        VehicleId = id;
        DriverName = driver;
        RatePerKm = rate;
    }

    // Abstract Method
    public abstract double CalculateFare(double distance);

    // Concrete Method
    public void GetVehicleDetails()
    {
        Console.WriteLine("Vehicle ID : " + VehicleId);
        Console.WriteLine("Driver Name : " + DriverName);
        Console.WriteLine("Rate Per KM : " + RatePerKm);
    }
}

// Car Class
class Car : Vehicle, IGPS
{
    private string location;

    public Car(int id, string driver, double rate)
        : base(id, driver, rate)
    {
    }

    public override double CalculateFare(double distance)
    {
        return distance * RatePerKm;
    }

    public void GetCurrentLocation()
    {
        Console.WriteLine("Current Location : " + location);
    }

    public void UpdateLocation(string location)
    {
        this.location = location;
    }
}

// Bike Class
class Bike : Vehicle, IGPS
{
    private string location;

    public Bike(int id, string driver, double rate)
        : base(id, driver, rate)
    {
    }

    public override double CalculateFare(double distance)
    {
        return distance * RatePerKm;
    }

    public void GetCurrentLocation()
    {
        Console.WriteLine("Current Location : " + location);
    }

    public void UpdateLocation(string location)
    {
        this.location = location;
    }
}

// Auto Class
class Auto : Vehicle, IGPS
{
    private string location;

    public Auto(int id, string driver, double rate)
        : base(id, driver, rate)
    {
    }

    public override double CalculateFare(double distance)
    {
        return distance * RatePerKm;
    }

    public void GetCurrentLocation()
    {
        Console.WriteLine("Current Location : " + location);
    }

    public void UpdateLocation(string location)
    {
        this.location = location;
    }
}

// Main Class
class Program
{
    static void Main()
    {
        List<Vehicle> vehicles = new List<Vehicle>();

        Car car = new Car(101, "Rahul", 20);
        car.UpdateLocation("Delhi");

        Bike bike = new Bike(102, "Aman", 10);
        bike.UpdateLocation("Noida");

        Auto auto = new Auto(103, "Rohit", 15);
        auto.UpdateLocation("Gurgaon");

        vehicles.Add(car);
        vehicles.Add(bike);
        vehicles.Add(auto);

        double distance = 10;

        Console.WriteLine("===== Ride Details =====\n");

        foreach (Vehicle vehicle in vehicles)
        {
            vehicle.GetVehicleDetails();

            Console.WriteLine("Distance : " + distance + " KM");

            Console.WriteLine("Total Fare : " +
                vehicle.CalculateFare(distance));

            IGPS gps = (IGPS)vehicle;
            gps.GetCurrentLocation();

            Console.WriteLine("-------------------------");
        }

        Console.ReadLine();
    }
}