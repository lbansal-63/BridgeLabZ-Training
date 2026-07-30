using System;
public class Program
{
    class BookDetail
    {
        public string title;
        public string author;
        public int price;

        public BookDetail(string title, string author, int price)
        {
            this.title = title;
            this.author = author;
            this.price = price;
        }

        public void print()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine("Price: {0:C} ",price);
            Console.WriteLine("------------------------");
        }
    }

    public static void Main()
    {
        BookDetail b1 = new BookDetail("Rich Dad Poor Dad", "Robert Kiyosaki", 350);
        BookDetail b2 = new BookDetail("The art of not giving fuck","Mark Manson",300);

        b1.print();
        b2.print();
    }
}