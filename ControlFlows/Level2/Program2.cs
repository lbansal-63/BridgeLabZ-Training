using System;

class LeapYear
{
    static void Main()
    {
        Console.Write("Enter a year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        if (year >= 1582 && (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0)))
        {
            Console.WriteLine("Year is a Leap Year");
        }
        else
        {
            Console.WriteLine("Year is not a Leap Year");
        }
    }
}
