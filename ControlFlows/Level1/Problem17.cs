using System;
public class Number
{
    public static void Main()
    {
        int salary,year;
        Console.Write("Enter your Salary: ");
        salary = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter year of service: ");
        year = Convert.ToInt32(Console.ReadLine());

        if (year > 5)
        {
            double bonus = salary * 0.05;
            Console.WriteLine("Bonus: " + bonus);
        }
        else
        {
            Console.WriteLine("No Bonus");
        }
    }
}