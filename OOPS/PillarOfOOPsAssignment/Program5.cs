using System;
using System.Collections.Generic;

// Interface
interface IReservable
{
    void ReserveItem();
    void CheckAvailability();
}

// Abstract Class
abstract class LibraryItem
{
    // Encapsulation
    private int itemId;
    private string title;
    private string author;
    private string borrowerName;

    // Properties
    public int ItemId
    {
        get { return itemId; }
        set { itemId = value; }
    }

    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public string Author
    {
        get { return author; }
        set { author = value; }
    }

    public string BorrowerName
    {
        get { return borrowerName; }
        set { borrowerName = value; }
    }

    // Constructor
    public LibraryItem(int id, string title, string author, string borrower)
    {
        ItemId = id;
        Title = title;
        Author = author;
        BorrowerName = borrower;
    }

    // Abstract Method
    public abstract int GetLoanDuration();

    // Concrete Method
    public void GetItemDetails()
    {
        Console.WriteLine("Item ID : " + ItemId);
        Console.WriteLine("Title : " + Title);
        Console.WriteLine("Author : " + Author);
    }
}

// Book Class
class Book : LibraryItem, IReservable
{
    public Book(int id, string title, string author, string borrower)
        : base(id, title, author, borrower)
    {
    }

    public override int GetLoanDuration()
    {
        return 15;   // 15 Days
    }

    public void ReserveItem()
    {
        Console.WriteLine("Book Reserved Successfully");
    }

    public void CheckAvailability()
    {
        Console.WriteLine("Book is Available");
    }
}

// Magazine Class
class Magazine : LibraryItem, IReservable
{
    public Magazine(int id, string title, string author, string borrower)
        : base(id, title, author, borrower)
    {
    }

    public override int GetLoanDuration()
    {
        return 7;   // 7 Days
    }

    public void ReserveItem()
    {
        Console.WriteLine("Magazine Reserved Successfully");
    }

    public void CheckAvailability()
    {
        Console.WriteLine("Magazine is Available");
    }
}

// DVD Class
class DVD : LibraryItem, IReservable
{
    public DVD(int id, string title, string author, string borrower)
        : base(id, title, author, borrower)
    {
    }

    public override int GetLoanDuration()
    {
        return 3;   // 3 Days
    }

    public void ReserveItem()
    {
        Console.WriteLine("DVD Reserved Successfully");
    }

    public void CheckAvailability()
    {
        Console.WriteLine("DVD is Available");
    }
}

// Main Class
class Program
{
    static void Main()
    {
        List<LibraryItem> items = new List<LibraryItem>();

        items.Add(new Book(101, "C# Programming", "James", "Rahul"));
        items.Add(new Magazine(102, "Tech Today", "John", "Aman"));
        items.Add(new DVD(103, "Avengers", "Marvel", "Rohit"));

        Console.WriteLine("===== Library Items =====\n");

        foreach (LibraryItem item in items)
        {
            item.GetItemDetails();

            Console.WriteLine("Loan Duration : " + item.GetLoanDuration() + " Days");

            IReservable reserve = (IReservable)item;
            reserve.CheckAvailability();
            reserve.ReserveItem();

            Console.WriteLine("---------------------------");
        }

        Console.ReadLine();
    }
}