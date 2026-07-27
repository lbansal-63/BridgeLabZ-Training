using System;

public class CalendarProgram
{
    // Method to get month name
    public static string GetMonthName(int month)
    {
        string[] months =
        {
            "January", "February", "March", "April",
            "May", "June", "July", "August",
            "September", "October", "November", "December"
        };

        return months[month - 1];
    }


    // Method to check leap year
    public static bool IsLeapYear(int year)
    {
        if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
            return true;

        return false;
    }


    // Method to get number of days in month
    public static int GetDaysInMonth(int month, int year)
    {
        int[] days =
        {
            31, 28, 31, 30, 31, 30,
            31, 31, 30, 31, 30, 31
        };

        if (month == 2 && IsLeapYear(year))
        {
            return 29;
        }

        return days[month - 1];
    }


    // Method to find first day of month using Gregorian algorithm
    public static int GetFirstDay(int day, int month, int year)
    {
        int y0 = year - (14 - month) / 12;

        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;

        int m0 = month + 12 * ((14 - month) / 12) - 2;

        int d0 = (day + x + (31 * m0) / 12) % 7;

        return d0;
    }


    // Method to display calendar
    public static void DisplayCalendar(int month, int year)
    {
        int days = GetDaysInMonth(month, year);

        int firstDay = GetFirstDay(1, month, year);

        Console.WriteLine("\n     " + GetMonthName(month) + " " + year);
        Console.WriteLine("---------------------------");
        Console.WriteLine(" Sun Mon Tue Wed Thu Fri Sat");

        // First loop for indentation
        for (int i = 0; i < firstDay; i++)
        {
            Console.Write("    ");
        }

        // Second loop for displaying dates
        for (int date = 1; date <= days; date++)
        {
            Console.Write("{0,4}", date);

            if ((date + firstDay) % 7 == 0)
            {
                Console.WriteLine();
            }
        }

        Console.WriteLine();
    }


    public static void Main()
    {
        Console.Write("Enter month (1-12): ");
        int month = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        DisplayCalendar(month, year);
    }
}
