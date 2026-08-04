using System;

class Vehicle
{
    public int MaxSpeed;
    public string FuelType;


    public Vehicle(int speed, string fuel)
    {
        MaxSpeed = speed;
        FuelType = fuel;
    }


    public virtual void DisplayInfo()
    {
        Console.WriteLine("Max Speed: " + MaxSpeed);
        Console.WriteLine("Fuel Type: " + FuelType);
    }
}



class Car : Vehicle
{
    public int SeatCapacity;


    public Car(int speed, string fuel, int seats)
        : base(speed, fuel)
    {
        SeatCapacity = seats;
    }


    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Seat Capacity: " + SeatCapacity);
    }
}



class Truck : Vehicle
{
    public int PayloadCapacity;


    public Truck(int speed, string fuel, int payload)
        : base(speed, fuel)
    {
        PayloadCapacity = payload;
    }


    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Payload Capacity: "
                          + PayloadCapacity);
    }
}



class Motorcycle : Vehicle
{
    public bool HasSidecar;


    public Motorcycle(int speed, string fuel, bool sidecar)
        : base(speed, fuel)
    {
        HasSidecar = sidecar;
    }


    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Has Sidecar: " + HasSidecar);
    }
}



class Program
{
    static void Main(string[] args)
    {

        Vehicle[] vehicles =
        {
            new Car(180,"Petrol",5),
            new Truck(120,"Diesel",5000),
            new Motorcycle(150,"Petrol",false)
        };


        foreach (Vehicle v in vehicles)
        {
            v.DisplayInfo();
            Console.WriteLine();
        }

    }
}