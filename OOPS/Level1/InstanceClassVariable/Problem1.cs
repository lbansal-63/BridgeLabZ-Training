using System;

class Product
{
    private string productName;
    private double price;

    private static int totalProducts = 0;

    public Product(string productName, double price)
    {
        this.productName = productName;
        this.price = price;
        totalProducts++;
    }

    public void DisplayProductDetails()
    {
        Console.WriteLine($"{productName} - {price}");
    }

    public static void DisplayTotalProducts()
    {
        Console.WriteLine("Total Products = " + totalProducts);
    }
}

class Program
{
    static void Main()
    {
        Product p1 = new Product("Laptop", 60000);
        Product p2 = new Product("Phone", 25000);

        p1.DisplayProductDetails();
        p2.DisplayProductDetails();

        Product.DisplayTotalProducts();
    }
}