using System;
public class Program6
{
    public static bool SpringSeason(int month,int day)
    {
        if ((month == 3 && day >= 20) || (month == 4) || (month == 5) || (month == 6 && day <= 20))
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
        int month,day;
        Console.Write("Enter the month(1-12): ");
        month = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the day: ");
        day = Convert.ToInt32(Console.ReadLine());

        bool res = Program6.SpringSeason(month,day);

        if (res == true)
        {
            Console.WriteLine("Spring Season");
        }
        else 
        {
            Console.WriteLine("Not a Spring Season");
        }
    }
}