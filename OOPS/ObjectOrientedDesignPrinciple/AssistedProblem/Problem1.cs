using System;
using System.Collections.Generic;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }

    public void DisplayBook()
    {
        Console.WriteLine($"{Title} by {Author}");
    }
}

class Library
{
    public string Name { get; set; }
    public List<Book> Books = new List<Book>();

    public Library(string name)
    {
        Name = name;
    }

    public void AddBook(Book book)
    {
        Books.Add(book);
    }

    public void ShowBooks()
    {
        Console.WriteLine($"\n{Name} Library Books:");
        foreach (Book b in Books)
            b.DisplayBook();
    }
}

class Program
{
    static void Main()
    {
        Book b1 = new Book("C# Basics", "John");
        Book b2 = new Book("OOP Concepts", "Alice");

        Library l1 = new Library("Central");
        Library l2 = new Library("City");

        l1.AddBook(b1);
        l1.AddBook(b2);

        l2.AddBook(b2);

        l1.ShowBooks();
        l2.ShowBooks();
    }
}