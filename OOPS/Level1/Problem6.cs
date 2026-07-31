using System;

class CarRental
{
    private string customerName;
    private string carModel;
    private int rentalDays;
    private double totalCost;

    public CarRental(string customerName, string carModel, int rentalDays)
    {
        this.customerName = customerName;
        this.carModel = carModel;
        this.rentalDays = rentalDays;
        CalculateCost();
    }

    private void CalculateCost()
    {
        totalCost = rentalDays * 2000;
    }

    public void Display()
    {
        Console.WriteLine($"{customerName}");
        Console.WriteLine($"{carModel}");
        Console.WriteLine($"Days: {rentalDays}");
        Console.WriteLine($"Total Cost: {totalCost}");
    }
}

class Program
{
    static void Main()
    {
        CarRental c = new CarRental("Rohan", "Swift", 4);
        c.Display();
    }
}