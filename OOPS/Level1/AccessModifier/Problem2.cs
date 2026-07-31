using System;

class Book
{
    public string ISBN;
    protected string title;
    private string author;

    public Book(string isbn, string title)
    {
        ISBN = isbn;
        this.title = title;
    }

    public void SetAuthor(string author)
    {
        this.author = author;
    }

    public string GetAuthor()
    {
        return author;
    }
}

class EBook : Book
{
    public EBook(string isbn, string title) : base(isbn, title)
    {
    }

    public void Display()
    {
        Console.WriteLine(ISBN);
        Console.WriteLine(title);
    }
}