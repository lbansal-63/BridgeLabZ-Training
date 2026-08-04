using System;
using System.Collections.Generic;


interface IInsurable
{
    double CalculateInsurance();
    void GetInsuranceDetails();
}

abstract class Vehicle
{
    private string vehicleNumber;
    private string type;
    private double rentalRate;
    private string insurancePolicyNumber;

    public string VehicleNumber
    {
        get { return vehicleNumber; }
        set { vehicleNumber = value; }
    }

    public string Type
    {
        get { return type; }
        set { type = value; }
    }

    public double RentalRate
    {
        get { return rentalRate; }
        set { rentalRate = value; }
    }

    public string InsurancePolicyNumber
    {
        get { return insurancePolicyNumber; }
        set { insurancePolicyNumber = value; }
    }

    public Vehicle(string number, string type, double rate, string policyNo)
    {
        VehicleNumber = number;
        Type = type;
        RentalRate = rate;
        InsurancePolicyNumber = policyNo;
    }

    public abstract double CalculateRentalCost(int days);

    public void DisplayDetails()
    {
        Console.WriteLine("Vehicle Number : " + VehicleNumber);
        Console.WriteLine("Vehicle Type : " + Type);
        Console.WriteLine("Rental Rate : " + RentalRate);
    }
}

class Car : Vehicle, IInsurable
{
    public Car(string number, double rate, string policyNo)
        : base(number, "Car", rate, policyNo)
    {
    }

    public override double CalculateRentalCost(int days)
    {
        return RentalRate * days;
    }

    public double CalculateInsurance()
    {
        return 1000;
    }

    public void GetInsuranceDetails()
    {
        Console.WriteLine("Insurance Cost : " + CalculateInsurance());
    }
}

class Bike : Vehicle, IInsurable
{
    public Bike(string number, double rate, string policyNo)
        : base(number, "Bike", rate, policyNo)
    {
    }

    public override double CalculateRentalCost(int days)
    {
        return RentalRate * days;
    }

    public double CalculateInsurance()
    {
        return 500;
    }

    public void GetInsuranceDetails()
    {
        Console.WriteLine("Insurance Cost : " + CalculateInsurance());
    }
}

class Truck : Vehicle, IInsurable
{
    public Truck(string number, double rate, string policyNo)
        : base(number, "Truck", rate, policyNo)
    {
    }

    public override double CalculateRentalCost(int days)
    {
        return RentalRate * days;
    }

    public double CalculateInsurance()
    {
        return 2000;
    }

    public void GetInsuranceDetails()
    {
        Console.WriteLine("Insurance Cost : " + CalculateInsurance());
    }
}

class Program
{
    static void Main()
    {
        List<Vehicle> vehicles = new List<Vehicle>();

        vehicles.Add(new Car("CAR101", 1500, "INS001"));
        vehicles.Add(new Bike("BIKE201", 500, "INS002"));
        vehicles.Add(new Truck("TRK301", 3000, "INS003"));

        int days = 5;

        Console.WriteLine("===== Vehicle Rental Details =====\n");

        foreach (Vehicle vehicle in vehicles)
        {
            vehicle.DisplayDetails();

            Console.WriteLine("Rental Cost (" + days + " Days) : " +
                vehicle.CalculateRentalCost(days));

            IInsurable insurance = (IInsurable)vehicle;
            insurance.GetInsuranceDetails();

            Console.WriteLine("------------------------------");
        }

        Console.ReadLine();
    }
}