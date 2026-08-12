using System;

class Movie
{
    public string Title;
    public string Director;
    public int Year;
    public double Rating;

    public Movie Next;
    public Movie Prev;

    public Movie(string title, string director, int year, double rating)
    {
        Title = title;
        Director = director;
        Year = year;
        Rating = rating;
    }
}

class MovieList
{
    private Movie head;
    private Movie tail;

    public void AddBeginning(string title, string director, int year, double rating)
    {
        Movie n = new Movie(title, director, year, rating);

        if (head == null)
            head = tail = n;
        else
        {
            n.Next = head;
            head.Prev = n;
            head = n;
        }
    }

    public void AddEnd(string title, string director, int year, double rating)
    {
        Movie n = new Movie(title, director, year, rating);

        if (tail == null)
            head = tail = n;
        else
        {
            tail.Next = n;
            n.Prev = tail;
            tail = n;
        }
    }

    public void AddAtPosition(int pos, string title, string director,
                               int year, double rating)
    {
        if (pos <= 1)
        {
            AddBeginning(title, director, year, rating);
            return;
        }

        Movie temp = head;

        for (int i = 1; i < pos - 1 && temp != null; i++)
            temp = temp.Next;

        if (temp == null)
        {
            Console.WriteLine("Invalid position.");
            return;
        }

        if (temp == tail)
        {
            AddEnd(title, director, year, rating);
            return;
        }

        Movie n = new Movie(title, director, year, rating);

        n.Next = temp.Next;
        n.Prev = temp;

        temp.Next.Prev = n;
        temp.Next = n;
    }

    public void Remove(string title)
    {
        Movie temp = head;

        while (temp != null && temp.Title != title)
            temp = temp.Next;

        if (temp == null)
        {
            Console.WriteLine("Movie not found.");
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

    public void SearchByDirector(string director)
    {
        Movie temp = head;

        while (temp != null)
        {
            if (temp.Director.Equals(director, StringComparison.OrdinalIgnoreCase))
                Print(temp);

            temp = temp.Next;
        }
    }

    public void SearchByRating(double rating)
    {
        Movie temp = head;

        while (temp != null)
        {
            if (temp.Rating == rating)
                Print(temp);

            temp = temp.Next;
        }
    }

    public void UpdateRating(string title, double rating)
    {
        Movie temp = head;

        while (temp != null)
        {
            if (temp.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
            {
                temp.Rating = rating;
                return;
            }

            temp = temp.Next;
        }

        Console.WriteLine("Movie not found.");
    }

    private void Print(Movie m)
    {
        Console.WriteLine(
            $"{m.Title} | {m.Director} | {m.Year} | Rating: {m.Rating}");
    }

    public void DisplayForward()
    {
        Console.WriteLine("\nForward:");

        Movie temp = head;

        while (temp != null)
        {
            Print(temp);
            temp = temp.Next;
        }
    }

    public void DisplayReverse()
    {
        Console.WriteLine("\nReverse:");

        Movie temp = tail;

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
        MovieList movies = new MovieList();

        movies.AddBeginning("Inception", "Christopher Nolan", 2010, 8.8);
        movies.AddEnd("Titanic", "James Cameron", 1997, 7.9);
        movies.AddAtPosition(2, "Interstellar", "Christopher Nolan", 2014, 8.7);

        movies.DisplayForward();
        movies.DisplayReverse();

        Console.WriteLine("\nMovies by Christopher Nolan:");
        movies.SearchByDirector("Christopher Nolan");

        movies.UpdateRating("Titanic", 8.0);
        movies.Remove("Inception");

        Console.WriteLine("\nAfter changes:");
        movies.DisplayForward();
    }
}