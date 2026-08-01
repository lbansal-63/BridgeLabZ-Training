using System;
using System.Collections.Generic;

class Product
{
    public string Name;

    public Product(string name)
    {
        Name = name;
    }
}

class Order
{
    public List<Product> Products = new List<Product>();

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public void ShowOrder()
    {
        Console.WriteLine("Order Items:");
        foreach (Product p in Products)
            Console.WriteLine(p.Name);
    }
}

class Customer
{
    public string Name;

    public Customer(string name)
    {
        Name = name;
    }

    public void PlaceOrder(Order order)
    {
        Console.WriteLine($"{Name} placed an order.");
        order.ShowOrder();
    }
}

class Program
{
    static void Main()
    {
        Customer customer = new Customer("Ali");

        Order order = new Order();

        order.AddProduct(new Product("Laptop"));
        order.AddProduct(new Product("Mouse"));

        customer.PlaceOrder(order);
    }
}