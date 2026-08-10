using System;
using System.Collections.Generic;

class Program
{
    static void AddProduct(
        Dictionary<string, double> cart,
        string product,
        double price)
    {
        cart[product] = price;
    }

    static void RemoveProduct(
        Dictionary<string, double> cart,
        string product)
    {
        if (cart.ContainsKey(product))
        {
            cart.Remove(product);
        }
    }

    static double CalculateTotal(
        Dictionary<string, double> cart)
    {
        double total = 0;

        foreach (var item in cart)
        {
            total += item.Value;
        }

        return total;
    }

    static void Main()
    {
        Dictionary<string, double> cart =
            new Dictionary<string, double>();

        // Add products
        AddProduct(cart, "Laptop", 50000);
        AddProduct(cart, "Mouse", 1000);
        AddProduct(cart, "Keyboard", 2000);
        AddProduct(cart, "Headphones", 3000);

        Console.WriteLine("SHOPPING CART:");

        foreach (var item in cart)
        {
            Console.WriteLine(
                item.Key + " = Rs." + item.Value);
        }

        // Remove product
        RemoveProduct(cart, "Mouse");

        Console.WriteLine("\nAFTER REMOVING MOUSE:");

        foreach (var item in cart)
        {
            Console.WriteLine(
                item.Key + " = Rs." + item.Value);
        }

        // Total
        double total = CalculateTotal(cart);

        Console.WriteLine(
            "\nTOTAL = Rs." + total);

        // Sort products by price
        List<KeyValuePair<string, double>> sortedProducts =
            new List<KeyValuePair<string, double>>(cart);

        sortedProducts.Sort(
            (x, y) => x.Value.CompareTo(y.Value)
        );

        Console.WriteLine("\nSORTED BY PRICE:");

        foreach (var item in sortedProducts)
        {
            Console.WriteLine(
                item.Key + " = Rs." + item.Value);
        }
    }
}