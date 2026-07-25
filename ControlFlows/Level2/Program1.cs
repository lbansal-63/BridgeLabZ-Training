using System; 
public class LeapYear
{
    public static void Main()
    {
        Console.Write("Enter a year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        if (year < 1582)
        {
            Console.WriteLine("Leap Year calculation is valid only for year >= 1582.");
        }
        else
        {
            if (year % 400 == 0)
            {
                Console.WriteLine("Year is a Leap Year");
            }
            else if (year % 100 == 0)
            {
                Console.WriteLine("Year is not a Leap Year");
            }
            else if (year % 4 == 0)
            {
                Console.WriteLine("Year is a Leap Year");
            }
            else
            {
                Console.WriteLine("Year is not a Leap Year");
            }
        }
}