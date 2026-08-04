using System;
using System.Collections.Generic;

// Interface
interface IDiscountable
{
    double ApplyDiscount();
    void GetDiscountDetails();
}

// Abstract Class
abstract class FoodItem
{
    // Encapsulation
    private string itemName;
    private double price;
    private int quantity;

    // Properties
    public string ItemName
    {
        get { return itemName; }
        set { itemName = value; }
    }

    public double Price
    {
        get { return price; }
        set { price = value; }
    }

    public int Quantity
    {
        get { return quantity; }
        set { quantity = value; }
    }

    // Constructor
    public FoodItem(string itemName, double price, int quantity)
    {
        ItemName = itemName;
        Price = price;
        Quantity = quantity;
    }

    // Abstract Method
    public abstract double CalculateTotalPrice();

    // Concrete Method
    public void GetItemDetails()
    {
        Console.WriteLine("Item Name : " + ItemName);
        Console.WriteLine("Price : " + Price);
        Console.WriteLine("Quantity : " + Quantity);
    }
}

// Veg Item
class VegItem : FoodItem, IDiscountable
{
    public VegItem(string itemName, double price, int quantity)
        : base(itemName, price, quantity)
    {
    }

    public override double CalculateTotalPrice()
    {
        return (Price * Quantity) + 20;   // ₹20 Delivery Charge
    }

    public double ApplyDiscount()
    {
        return 50;   // Flat ₹50 Discount
    }

    public void GetDiscountDetails()
    {
        Console.WriteLine("Discount : " + ApplyDiscount());
    }
}

// Non-Veg Item
class NonVegItem : FoodItem, IDiscountable
{
    public NonVegItem(string itemName, double price, int quantity)
        : base(itemName, price, quantity)
    {
    }

    public override double CalculateTotalPrice()
    {
        return (Price * Quantity) + 50;   // ₹50 Delivery Charge
    }

    public double ApplyDiscount()
    {
        return 30;   // Flat ₹30 Discount
    }

    public void GetDiscountDetails()
    {
        Console.WriteLine("Discount : " + ApplyDiscount());
    }
}

// Main Class
class Program
{
    static void Main()
    {
        List<FoodItem> foodItems = new List<FoodItem>();

        foodItems.Add(new VegItem("Paneer Pizza", 300, 2));
        foodItems.Add(new NonVegItem("Chicken Burger", 250, 3));

        Console.WriteLine("===== Food Order Details =====\n");

        foreach (FoodItem item in foodItems)
        {
            item.GetItemDetails();

            double total = item.CalculateTotalPrice();

            IDiscountable discount = (IDiscountable)item;
            discount.GetDiscountDetails();

            double finalPrice = total - discount.ApplyDiscount();

            Console.WriteLine("Total Price : " + total);
            Console.WriteLine("Final Price : " + finalPrice);

            Console.WriteLine("----------------------------");
        }

        Console.ReadLine();
    }
}