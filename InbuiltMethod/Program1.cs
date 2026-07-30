using System; 
public class Program
{
    public static void Main()
    {
        DateTime dt = DateTime.Now;

        Console.WriteLine("{0:d}",dt); // short date
        Console.WriteLine("{0:D}", dt); // long date
        Console.WriteLine("{0:f}", dt); // full date/time (short)
        Console.WriteLine("{0:F}", dt); // full date/time (long)
        Console.WriteLine("{0:g}", dt); // general date/time (short)
        Console.WriteLine("{0:y}", dt); // general date/time (long)
        Console.WriteLine("{0:d} {1:D}", dt,dt); 
        Console.WriteLine("{0:m}", dt); // date month
        Console.WriteLine("{0:M}", dt); // date month
        Console.WriteLine("{0:t}", dt); // short time
        Console.WriteLine("{0:T}", dt); // long time
        Console.WriteLine("{0:y}", dt); // month year
        Console.WriteLine("{0:Y}", dt); // month year 
        Console.WriteLine("{0:yy}", dt); // last 2 digit of year
        Console.WriteLine("{0:yyyy}", dt); // year 
        Console.WriteLine("{0:ddd}", dt); // Abbrivated week in short
        Console.WriteLine("{0:dddd}", dt); // week in full 
        Console.WriteLine("{0:FF}", dt); // fraction seconds of time
        Console.WriteLine("{0:HH}", dt); // hour (00-23)
        Console.WriteLine("{0:MM}", dt); // month (01-12)
        Console.WriteLine("{0:MMM}", dt); // Abbrivated month name 
        Console.WriteLine("{0:ss}", dt); // seconds as number (0-59)
        Console.WriteLine("{0:HH:mm:ss tt}", dt); // print time 
        Console.WriteLine("{0:hh-mm-ss tt}", dt); // print time (another format)
        Console.WriteLine("{0:dd-MM-yyyy}", dt); // print date 
    }
}


