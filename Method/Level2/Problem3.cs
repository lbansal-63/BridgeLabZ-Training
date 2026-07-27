using System;
public class Problem3
{
    public static bool LeapYear(int year)
    {
        if (year >= 1582 && ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)))
        {
            return true;
        }
        else
        {
            return false; 
        }
    }

    public static void Main()
    {
        int year;
        Console.Write("Enter the year: ");
        year = Convert.ToInt32(Console.ReadLine());

        bool IsLeapYear = Problem3.LeapYear(year);

        if (IsLeapYear)
        {
            Console.WriteLine("Yes, Its Leap Year");
        }
        else
        {
            Console.WriteLine("No, Its not a Leap Year"); 
        }
    }
}