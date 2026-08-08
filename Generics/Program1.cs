using System;
using System.Collections.Generic;

// ===============================
// 1. Abstract Base Class
// ===============================

public abstract class WarehouseItem
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }

    public WarehouseItem(int id, string name, double price)
    {
        Id = id;
        Name = name;
        Price = price;
    }

    public abstract void DisplayInfo();
}


// ===============================
// 2. Electronics Class
// ===============================

public class Electronics : WarehouseItem
{
    public int WarrantyMonths { get; set; }

    public Electronics(
        int id,
        string name,
        double price,
        int warrantyMonths)
        : base(id, name, price)
    {
        WarrantyMonths = warrantyMonths;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine(
            $"Electronics | ID: {Id} | " +
            $"Name: {Name} | Price: {Price} | " +
            $"Warranty: {WarrantyMonths} months");
    }
}


// ===============================
// 3. Grocery Class
// ===============================

public class Grocery : WarehouseItem
{
    public DateTime ExpiryDate { get; set; }

    public Grocery(
        int id,
        string name,
        double price,
        DateTime expiryDate)
        : base(id, name, price)
    {
        ExpiryDate = expiryDate;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine(
            $"Grocery | ID: {Id} | " +
            $"Name: {Name} | Price: {Price} | " +
            $"Expiry: {ExpiryDate:dd-MM-yyyy}");
    }
}


// ===============================
// 4. Furniture Class
// ===============================

public class Furniture : WarehouseItem
{
    public string Material { get; set; }

    public Furniture(
        int id,
        string name,
        double price,
        string material)
        : base(id, name, price)
    {
        Material = material;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine(
            $"Furniture | ID: {Id} | " +
            $"Name: {Name} | Price: {Price} | " +
            $"Material: {Material}");
    }
}


// ===============================
// 5. Generic Storage Class
// ===============================

public class Storage<T> where T : WarehouseItem
{
    private List<T> items;

    public Storage()
    {
        items = new List<T>();
    }

    // Add item
    public void AddItem(T item)
    {
        items.Add(item);
        Console.WriteLine(
            $"{item.Name} added successfully.");
    }

    // Display all items
    public void DisplayAllItems()
    {
        Console.WriteLine("\n--- Storage Items ---");

        foreach (T item in items)
        {
            item.DisplayInfo();
        }
    }

    // Get total number of items
    public int GetCount()
    {
        return items.Count;
    }
}


// ===============================
// 6. Program Class
// ===============================

public class Program
{
    public static void Main()
    {
        // --------------------------------
        // Create Electronics
        // --------------------------------

        Electronics laptop = new Electronics(
            1,
            "Dell Laptop",
            75000,
            24
        );

        Electronics mobile = new Electronics(
            2,
            "iPhone",
            90000,
            12
        );


        // --------------------------------
        // Create Groceries
        // --------------------------------

        Grocery rice = new Grocery(
            3,
            "Rice",
            1200,
            new DateTime(2027, 5, 20)
        );

        Grocery milk = new Grocery(
            4,
            "Milk",
            70,
            new DateTime(2026, 8, 15)
        );


        // --------------------------------
        // Create Furniture
        // --------------------------------

        Furniture chair = new Furniture(
            5,
            "Office Chair",
            5000,
            "Wood"
        );

        Furniture table = new Furniture(
            6,
            "Dining Table",
            15000,
            "Wood"
        );


        // =================================
        // Generic Storage<Electronics>
        // =================================

        Storage<Electronics> electronicStorage =
            new Storage<Electronics>();

        electronicStorage.AddItem(laptop);
        electronicStorage.AddItem(mobile);

        electronicStorage.DisplayAllItems();

        Console.WriteLine(
            $"Total Electronics: " +
            $"{electronicStorage.GetCount()}");


        // =================================
        // Generic Storage<Grocery>
        // =================================

        Storage<Grocery> groceryStorage =
            new Storage<Grocery>();

        groceryStorage.AddItem(rice);
        groceryStorage.AddItem(milk);

        groceryStorage.DisplayAllItems();

        Console.WriteLine(
            $"Total Groceries: " +
            $"{groceryStorage.GetCount()}");


        // =================================
        // Generic Storage<Furniture>
        // =================================

        Storage<Furniture> furnitureStorage =
            new Storage<Furniture>();

        furnitureStorage.AddItem(chair);
        furnitureStorage.AddItem(table);

        furnitureStorage.DisplayAllItems();

        Console.WriteLine(
            $"Total Furniture: " +
            $"{furnitureStorage.GetCount()}");


        Console.WriteLine("\nProgram Finished.");
    }
}