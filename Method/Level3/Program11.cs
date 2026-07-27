using System;

public class ZaraBonus
{
    // Method to generate salary and years of service
    public static int[,] GenerateEmployeeData(int employees)
    {
        int[,] employeeData = new int[employees, 2];

        Random random = new Random();

        for (int i = 0; i < employees; i++)
        {
            // 5 digit salary (10000 to 99999)
            employeeData[i, 0] = random.Next(10000, 100000);

            // Years of service (1 to 20 years)
            employeeData[i, 1] = random.Next(1, 21);
        }

        return employeeData;
    }


    // Method to calculate bonus and new salary
    public static double[,] CalculateBonus(int[,] employeeData)
    {
        double[,] salaryData = new double[employeeData.GetLength(0), 2];

        for (int i = 0; i < employeeData.GetLength(0); i++)
        {
            double salary = employeeData[i, 0];
            int years = employeeData[i, 1];

            double bonus;

            if (years > 5)
            {
                bonus = salary * 0.05;
            }
            else
            {
                bonus = salary * 0.02;
            }

            double newSalary = salary + bonus;

            salaryData[i, 0] = newSalary;
            salaryData[i, 1] = bonus;
        }

        return salaryData;
    }


    // Method to calculate totals
    public static void DisplaySalaryReport(int[,] employeeData, double[,] salaryData)
    {
        double totalOldSalary = 0;
        double totalNewSalary = 0;
        double totalBonus = 0;

        Console.WriteLine("\nEmployee Salary Report");
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("Emp\tOld Salary\tService\tBonus\t\tNew Salary");

        for (int i = 0; i < employeeData.GetLength(0); i++)
        {
            double oldSalary = employeeData[i, 0];
            int years = employeeData[i, 1];

            double bonus = salaryData[i, 1];
            double newSalary = salaryData[i, 0];

            Console.WriteLine(
                (i + 1) + "\t" +
                oldSalary + "\t\t" +
                years + "\t" +
                bonus + "\t" +
                newSalary
            );

            totalOldSalary += oldSalary;
            totalNewSalary += newSalary;
            totalBonus += bonus;
        }

        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("Total Old Salary : " + totalOldSalary);
        Console.WriteLine("Total Bonus      : " + totalBonus);
        Console.WriteLine("Total New Salary : " + totalNewSalary);
    }


    public static void Main()
    {
        int employees = 10;

        // Generate employee details
        int[,] employeeData = GenerateEmployeeData(employees);

        // Calculate bonus and new salary
        double[,] salaryData = CalculateBonus(employeeData);

        // Display report
        DisplaySalaryReport(employeeData, salaryData);
    }
}
