using System;

class HotelBooking
{
    private string guestName;
    private string roomType;
    private int nights;

    public HotelBooking()
    {
        guestName = "Guest";
        roomType = "Standard";
        nights = 1;
    }

    public HotelBooking(string guestName, string roomType, int nights)
    {
        this.guestName = guestName;
        this.roomType = roomType;
        this.nights = nights;
    }

    public HotelBooking(HotelBooking h)
    {
        guestName = h.guestName;
        roomType = h.roomType;
        nights = h.nights;
    }

    public void Display()
    {
        Console.WriteLine($"{guestName} | {roomType} | {nights} nights");
    }
}

class Program
{
    static void Main()
    {
        HotelBooking h1 = new HotelBooking();
        HotelBooking h2 = new HotelBooking("Amit", "Deluxe", 3);
        HotelBooking h3 = new HotelBooking(h2);

        h1.Display();
        h2.Display();
        h3.Display();
    }
}