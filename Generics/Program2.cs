using System;
using System.Collections.Generic;

// =====================================
// Base Category
// =====================================

public abstract class ProductCategory
{
    public string CategoryName { get; set; }

    public ProductCategory(string categoryName)
    {
        CategoryName = categoryName;
    }
}


// =====================================
// Categories
// =====================================

public class BookCategory : ProductCategory
{
    public BookCategory()
        : base("Book")
    {
    }
}

public class ClothingCategory : ProductCategory
{
    public ClothingCategory()
        : base("Clothing")
    {
    }
}


// =====================================
// Base Product
// =====================================

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }

    public Product(int id, string name, double price)
    {
        Id = id;
        Name = name;
        Price = price;
    }

    public virtual void Display()
    {
        Console.WriteLine(
            $"ID: {Id}, Name: {Name}, Price: {Price}");
    }
}


// =====================================
// Generic Product
// =====================================

public class Product<T> : Product
    where T : ProductCategory
{
    public T Category { get; set; }

    public Product(
        int id,
        string name,
        double price,
        T category)
        : base(id, name, price)
    {
        Category = category;
    }

    public override void Display()
    {
        Console.WriteLine(
            $"ID: {Id}, " +
            $"Name: {Name}, " +
            $"Price: {Price}, " +
            $"Category: {Category.CategoryName}");
    }
}


// =====================================
// Marketplace
// =====================================

public class Marketplace
{
    private List<Product> products =
        new List<Product>();

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public void DisplayProducts()
    {
        foreach (Product product in products)
        {
            product.Display();
        }
    }

    // Generic Method
    public void ApplyDiscount<T>(
        T product,
        double percentage)
        where T : Product
    {
        product.Price =
            product.Price -
            (product.Price * percentage / 100);

        Console.WriteLine(
            $"Discount applied to {product.Name}");
    }
}


// =====================================
// Program
// =====================================

public class Program
{
    public static void Main()
    {
        Product<BookCategory> book =
            new Product<BookCategory>(
                1,
                "C# Programming",
                1000,
                new BookCategory());

        Product<ClothingCategory> shirt =
            new Product<ClothingCategory>(
                2,
                "T-Shirt",
                1500,
                new ClothingCategory());

        Marketplace marketplace =
            new Marketplace();

        marketplace.AddProduct(book);
        marketplace.AddProduct(shirt);

        Console.WriteLine("Products:");

        marketplace.DisplayProducts();

        Console.WriteLine("\nApplying Discount:");

        marketplace.ApplyDiscount(book, 20);

        Console.WriteLine(
            $"New Price: {book.Price}");
    }
}