using System;

class Book
{
    private string title;
    private string author;
    private double price;

    // Default Constructor
    public Book()
    {
        title = "Unknown";
        author = "Unknown";
        price = 0;
    }

    // Parameterized Constructor
    public Book(string title, string author, double price)
    {
        this.title = title;
        this.author = author;
        this.price = price;
    }

    public void Display()
    {
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Price: {price}");
    }
}

class Program
{
    static void Main()
    {
        Book b1 = new Book();
        Book b2 = new Book("C# Basics", "John", 450);

        b1.Display();
        Console.WriteLine();
        b2.Display();
    }
}