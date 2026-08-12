using System;

class Book
{
    public string Title;
    public string Author;
    public string Genre;
    public int ID;
    public bool Available;

    public Book Next;
    public Book Prev;

    public Book(string title, string author, string genre, int id, bool available)
    {
        Title = title;
        Author = author;
        Genre = genre;
        ID = id;
        Available = available;
    }
}

class Library
{
    private Book head;
    private Book tail;

    public void AddBeginning(string title, string author, string genre,
                              int id, bool available)
    {
        Book n = new Book(title, author, genre, id, available);

        if (head == null)
            head = tail = n;
        else
        {
            n.Next = head;
            head.Prev = n;
            head = n;
        }
    }

    public void AddEnd(string title, string author, string genre,
                        int id, bool available)
    {
        Book n = new Book(title, author, genre, id, available);

        if (tail == null)
            head = tail = n;
        else
        {
            tail.Next = n;
            n.Prev = tail;
            tail = n;
        }
    }

    public void AddAtPosition(int pos, string title, string author,
                              string genre, int id, bool available)
    {
        if (pos <= 1)
        {
            AddBeginning(title, author, genre, id, available);
            return;
        }

        Book temp = head;

        for (int i = 1; i < pos - 1 && temp != null; i++)
            temp = temp.Next;

        if (temp == null)
        {
            Console.WriteLine("Invalid position.");
            return;
        }

        if (temp == tail)
        {
            AddEnd(title, author, genre, id, available);
            return;
        }

        Book n = new Book(title, author, genre, id, available);

        n.Next = temp.Next;
        n.Prev = temp;

        temp.Next.Prev = n;
        temp.Next = n;
    }

    public void Remove(int id)
    {
        Book temp = head;

        while (temp != null && temp.ID != id)
            temp = temp.Next;

        if (temp == null)
        {
            Console.WriteLine("Book not found.");
            return;
        }

        if (temp.Prev != null)
            temp.Prev.Next = temp.Next;
        else
            head = temp.Next;

        if (temp.Next != null)
            temp.Next.Prev = temp.Prev;
        else
            tail = temp.Prev;
    }

    public void SearchByTitle(string title)
    {
        Book temp = head;

        while (temp != null)
        {
            if (temp.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                Print(temp);

            temp = temp.Next;
        }
    }

    public void SearchByAuthor(string author)
    {
        Book temp = head;

        while (temp != null)
        {
            if (temp.Author.Equals(author, StringComparison.OrdinalIgnoreCase))
                Print(temp);

            temp = temp.Next;
        }
    }

    public void UpdateAvailability(int id, bool status)
    {
        Book temp = head;

        while (temp != null)
        {
            if (temp.ID == id)
            {
                temp.Available = status;
                return;
            }

            temp = temp.Next;
        }

        Console.WriteLine("Book not found.");
    }

    public int Count()
    {
        int count = 0;
        Book temp = head;

        while (temp != null)
        {
            count++;
            temp = temp.Next;
        }

        return count;
    }

    private void Print(Book b)
    {
        Console.WriteLine(
            $"ID: {b.ID}, Title: {b.Title}, Author: {b.Author}, " +
            $"Genre: {b.Genre}, Available: {b.Available}");
    }

    public void DisplayForward()
    {
        Console.WriteLine("\nForward:");

        Book temp = head;

        while (temp != null)
        {
            Print(temp);
            temp = temp.Next;
        }
    }

    public void DisplayReverse()
    {
        Console.WriteLine("\nReverse:");

        Book temp = tail;

        while (temp != null)
        {
            Print(temp);
            temp = temp.Prev;
        }
    }
}

class Program
{
    static void Main()
    {
        Library library = new Library();

        library.AddBeginning(
            "The Alchemist", "Paulo Coelho", "Fiction", 1, true);

        library.AddEnd(
            "1984", "George Orwell", "Dystopian", 2, true);

        library.AddAtPosition(
            2, "Harry Potter", "J.K. Rowling", "Fantasy", 3, false);

        library.DisplayForward();
        library.DisplayReverse();

        library.UpdateAvailability(3, true);

        Console.WriteLine("\nTotal Books: " + library.Count());
    }
}