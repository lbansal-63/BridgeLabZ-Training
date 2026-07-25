using System;
public class Number
{
    public static void Main()
    {
        int month;
        Console.WriteLine("Enter the Month(1-12): ");
        month = Convert.ToInt32(Console.ReadLine());

        int day;
        Console.Write("Enter day: ");
        day = Convert.ToInt32(Console.ReadLine());

        if ((month==3 && day=>20) || month==4 ||month==5 || month==6 && day<=20)
        {
            Console.WriteLine("Its a Spring Season");
        }
        else
        {
            Console.WriteLine("Its not a spring Season");
        }
    }
}