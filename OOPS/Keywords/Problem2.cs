using System;

class Book
{
    public static string LibraryName = "City Library";

    public string Title;
    public string Author;
    public readonly string ISBN;

    public Book(string title, string author, string isbn)
    {
        this.Title = title;
        this.Author = author;
        this.ISBN = isbn;
    }

    public void Display()
    {
        Console.WriteLine("Title : " + Title);
        Console.WriteLine("Author : " + Author);
        Console.WriteLine("ISBN : " + ISBN);
    }

    public static void DisplayLibraryName()
    {
        Console.WriteLine("Library : " + LibraryName);
    }
}

class Program
{
    static void Main()
    {
        Book b = new Book("C# Programming", "John", "ISBN101");

        if (b is Book)
        {
            b.Display();
        }

        Book.DisplayLibraryName();
    }
}