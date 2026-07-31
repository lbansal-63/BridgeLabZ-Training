using System;

class Book
{
    private string title;
    private string author;
    private double price;
    private bool available;

    public Book(string title, string author, double price)
    {
        this.title = title;
        this.author = author;
        this.price = price;
        available = true;
    }

    public void BorrowBook()
    {
        if (available)
        {
            available = false;
            Console.WriteLine("Book Borrowed Successfully.");
        }
        else
        {
            Console.WriteLine("Book is not available.");
        }
    }

    public void Display()
    {
        Console.WriteLine($"{title} | {author} | {price} | Available: {available}");
    }
}

class Program
{
    static void Main()
    {
        Book b = new Book("Java", "James", 500);

        b.Display();
        b.BorrowBook();
        b.Display();
    }
}