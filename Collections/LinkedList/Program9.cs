using System;

class Ticket
{
    public int TicketID;
    public string CustomerName;
    public string MovieName;
    public string SeatNumber;
    public string BookingTime;

    public Ticket Next;

    public Ticket(int id, string customer, string movie,
                  string seat, string bookingTime)
    {
        TicketID = id;
        CustomerName = customer;
        MovieName = movie;
        SeatNumber = seat;
        BookingTime = bookingTime;
    }
}

class TicketReservation
{
    private Ticket head;
    private Ticket tail;

    public void AddTicket(int id, string customer, string movie,
                           string seat, string bookingTime)
    {
        Ticket n = new Ticket(
            id, customer, movie, seat, bookingTime);

        if (head == null)
        {
            head = tail = n;
            n.Next = head;
        }
        else
        {
            n.Next = head;
            tail.Next = n;
            tail = n;
        }
    }

    public void RemoveTicket(int id)
    {
        if (head == null)
        {
            Console.WriteLine("No tickets.");
            return;
        }

        Ticket current = head;
        Ticket previous = tail;

        do
        {
            if (current.TicketID == id)
            {
                if (current == head)
                    head = head.Next;

                if (current == tail)
                    tail = previous;

                previous.Next = current.Next;

                // Only one node existed.
                if (current == head && current == tail)
                    head = tail = null;

                Console.WriteLine("Ticket removed.");
                return;
            }

            previous = current;
            current = current.Next;

        } while (current != head);

        Console.WriteLine("Ticket not found.");
    }

    public void SearchByCustomer(string customer)
    {
        if (head == null)
            return;

        Ticket temp = head;

        do
        {
            if (temp.CustomerName.Equals(
                customer, StringComparison.OrdinalIgnoreCase))
            {
                Print(temp);
            }

            temp = temp.Next;

        } while (temp != head);
    }

    public void SearchByMovie(string movie)
    {
        if (head == null)
            return;

        Ticket temp = head;

        do
        {
            if (temp.MovieName.Equals(
                movie, StringComparison.OrdinalIgnoreCase))
            {
                Print(temp);
            }

            temp = temp.Next;

        } while (temp != head);
    }

    public int CountTickets()
    {
        if (head == null)
            return 0;

        int count = 0;
        Ticket temp = head;

        do
        {
            count++;
            temp = temp.Next;

        } while (temp != head);

        return count;
    }

    public void Display()
    {
        if (head == null)
        {
            Console.WriteLine("No tickets booked.");
            return;
        }

        Ticket temp = head;

        do
        {
            Print(temp);
            temp = temp.Next;

        } while (temp != head);
    }

    private void Print(Ticket ticket)
    {
        Console.WriteLine(
            $"Ticket ID: {ticket.TicketID}, " +
            $"Customer: {ticket.CustomerName}, " +
            $"Movie: {ticket.MovieName}, " +
            $"Seat: {ticket.SeatNumber}, " +
            $"Booking Time: {ticket.BookingTime}");
    }
}

class Program
{
    static void Main()
    {
        TicketReservation system = new TicketReservation();

        system.AddTicket(
            101, "Rahul", "Avengers", "A10", "10:30 AM");

        system.AddTicket(
            102, "Priya", "Avatar", "B12", "11:00 AM");

        system.AddTicket(
            103, "Aman", "Avengers", "A11", "11:15 AM");

        Console.WriteLine("All Tickets:");
        system.Display();

        Console.WriteLine("\nAvengers Tickets:");
        system.SearchByMovie("Avengers");

        Console.WriteLine("\nTickets booked by Rahul:");
        system.SearchByCustomer("Rahul");

        Console.WriteLine(
            $"\nTotal Tickets: {system.CountTickets()}");

        system.RemoveTicket(102);

        Console.WriteLine("\nAfter cancellation:");
        system.Display();
    }
}