using System;
using System.Collections.Generic;

// Interface
interface ITaxable
{
    double CalculateTax();
    void GetTaxDetails();
}

// Abstract Class
abstract class Product
{
    // Encapsulation
    private int productId;
    private string name;
    private double price;

    // Properties
    public int ProductId
    {
        get { return productId; }
        set { productId = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public double Price
    {
        get { return price; }
        set { price = value; }
    }

    // Constructor
    public Product(int id, string name, double price)
    {
        ProductId = id;
        Name = name;
        Price = price;
    }

    // Abstract Method
    public abstract double CalculateDiscount();

    // Concrete Method
    public void DisplayDetails()
    {
        Console.WriteLine("Product ID : " + ProductId);
        Console.WriteLine("Product Name : " + Name);
        Console.WriteLine("Price : " + Price);
    }
}

// Electronics Class
class Electronics : Product, ITaxable
{
    public Electronics(int id, string name, double price)
        : base(id, name, price)
    {
    }

    public override double CalculateDiscount()
    {
        return Price * 0.10;   // 10% Discount
    }

    public double CalculateTax()
    {
        return Price * 0.18;   // 18% Tax
    }

    public void GetTaxDetails()
    {
        Console.WriteLine("Tax (18%) : " + CalculateTax());
    }
}

// Clothing Class
class Clothing : Product, ITaxable
{
    public Clothing(int id, string name, double price)
        : base(id, name, price)
    {
    }

    public override double CalculateDiscount()
    {
        return Price * 0.20;   // 20% Discount
    }

    public double CalculateTax()
    {
        return Price * 0.12;   // 12% Tax
    }

    public void GetTaxDetails()
    {
        Console.WriteLine("Tax (12%) : " + CalculateTax());
    }
}

// Groceries Class
class Groceries : Product
{
    public Groceries(int id, string name, double price)
        : base(id, name, price)
    {
    }

    public override double CalculateDiscount()
    {
        return Price * 0.05;   // 5% Discount
    }
}

// Main Class
class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>();

        products.Add(new Electronics(101, "Laptop", 50000));
        products.Add(new Clothing(102, "T-Shirt", 1000));
        products.Add(new Groceries(103, "Rice", 2000));

        Console.WriteLine("===== Product Details =====\n");

        foreach (Product product in products)
        {
            product.DisplayDetails();

            double tax = 0;

            if (product is ITaxable taxable)
            {
                tax = taxable.CalculateTax();
                taxable.GetTaxDetails();
            }

            double discount = product.CalculateDiscount();

            Console.WriteLine("Discount : " + discount);

            double finalPrice = product.Price + tax - discount;

            Console.WriteLine("Final Price : " + finalPrice);

            Console.WriteLine("---------------------------");
        }

        Console.ReadLine();
    }
}