using System;


interface Refuelable
{
    void Refuel();
}



class Vehicle
{
    public int MaxSpeed;
    public string Model;


    public Vehicle(int speed, string model)
    {
        MaxSpeed = speed;
        Model = model;
    }
}



class ElectricVehicle : Vehicle
{

    public ElectricVehicle(
        int speed,
        string model)
        : base(speed, model)
    {
    }


    public void Charge()
    {
        Console.WriteLine(
            Model + " is charging");
    }
}



class PetrolVehicle : Vehicle, Refuelable
{

    public PetrolVehicle(
        int speed,
        string model)
        : base(speed, model)
    {
    }


    public void Refuel()
    {
        Console.WriteLine(
            Model + " is refueling");
    }
}



class Program
{
    static void Main(string[] args)
    {

        ElectricVehicle ev =
            new ElectricVehicle(
                200,
                "Tesla"
            );


        PetrolVehicle pv =
            new PetrolVehicle(
                180,
                "Toyota"
            );


        ev.Charge();

        pv.Refuel();

    }
}