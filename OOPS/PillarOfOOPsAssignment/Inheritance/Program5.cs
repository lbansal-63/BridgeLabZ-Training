using System;


class Device
{
    public int DeviceId;
    public string Status;


    public Device(int id, string status)
    {
        DeviceId = id;
        Status = status;
    }


    public virtual void DisplayStatus()
    {
        Console.WriteLine("Device ID: " + DeviceId);
        Console.WriteLine("Status: " + Status);
    }
}



class Thermostat : Device
{
    public double TemperatureSetting;


    public Thermostat(int id, string status, double temperature)
        : base(id, status)
    {
        TemperatureSetting = temperature;
    }


    public override void DisplayStatus()
    {
        base.DisplayStatus();
        Console.WriteLine(
            "Temperature Setting: " + TemperatureSetting + "°C");
    }
}



class Program
{
    static void Main(string[] args)
    {
        Thermostat t = new Thermostat(
            101,
            "ON",
            24.5
        );


        t.DisplayStatus();
    }
}