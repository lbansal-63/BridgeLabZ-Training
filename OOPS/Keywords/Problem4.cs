using System;

class Product
{
    public static double Discount = 10;

    public string ProductName;
    public double Price;
    public int Quantity;
    public readonly int ProductID;

    public Product(string productName, double price, int quantity, int productID)
    {
        this.ProductName = productName;
        this.Price = price;
        this.Quantity = quantity;
        this.ProductID = productID;
    }

    public void Display()
    {
        Console.WriteLine("Product : " + ProductName);
        Console.WriteLine("Price : " + Price);
        Console.WriteLine("Quantity : " + Quantity);
        Console.WriteLine("Product ID : " + ProductID);
        Console.WriteLine("Discount : " + Discount + "%");
    }

    public static void UpdateDiscount(double discount)
    {
        Discount = discount;
    }
}

class Program
{
    static void Main()
    {
        Product.UpdateDiscount(15);

        Product p = new Product("Laptop", 50000, 2, 501);

        if (p is Product)
        {
            p.Display();
        }
    }
}