using System;

public class Array
{
    public static void Main()
    {
        double[] salary = new double[10];
        double[] years = new double[10];
        double[] bonus = new double[10];
        double[] newSalary = new double[10];

        double totalBonus = 0;
        double totalOldSalary = 0;
        double totalNewSalary = 0;

        // Input
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Enter salary of employee " + (i + 1) + ": ");
            salary[i] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter years of service: ");
            years[i] = Convert.ToDouble(Console.ReadLine());

            if (salary[i] <= 0 || years[i] < 0)
            {
                Console.WriteLine("Invalid input. Enter again.");
                i--;
            }
        }

        // Calculate bonus
        for (int i = 0; i < 10; i++)
        {
            if (years[i] > 5)
            {
                bonus[i] = salary[i] * 0.05;
            }
            else
            {
                bonus[i] = salary[i] * 0.02;
            }

            newSalary[i] = salary[i] + bonus[i];

            totalBonus += bonus[i];
            totalOldSalary += salary[i];
            totalNewSalary += newSalary[i];
        }

        Console.WriteLine("\nTotal Bonus Paid: " + totalBonus);
        Console.WriteLine("Total Old Salary: " + totalOldSalary);
        Console.WriteLine("Total New Salary: " + totalNewSalary);
    }
}
