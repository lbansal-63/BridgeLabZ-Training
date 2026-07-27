using System;

public class BMI
{
    public static void CalculateBMI(double[,] persons)
    {
        for (int i = 0; i < persons.GetLength(0); i++)
        {
            double weight = persons[i, 0];
            double heightInMeter = persons[i, 1] / 100; 

            persons[i, 2] = weight / (heightInMeter * heightInMeter);
        }
    }

    public static string[] FindBMIStatus(double[,] persons)
    {
        string[] status = new string[persons.GetLength(0)];

        for (int i = 0; i < persons.GetLength(0); i++)
        {
            double bmi = persons[i, 2];

            if (bmi <= 18.4)
            {
                status[i] = "Underweight";
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                status[i] = "Normal";
            }
            else if (bmi >= 25.0 && bmi <= 39.9)
            {
                status[i] = "Overweight";
            }
            else
            {
                status[i] = "Obese";
            }
        }

        return status;
    }

    public static void Main()
    {
        double[,] persons = new double[10, 3];

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Person " + (i + 1));

            Console.Write("Enter weight (kg): ");
            persons[i, 0] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter height (cm): ");
            persons[i, 1] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
        }

        CalculateBMI(persons);

        string[] bmiStatus = FindBMIStatus(persons);

        Console.WriteLine("Weight\tHeight\tBMI\tStatus");

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(
                persons[i, 0] + "\t" +
                persons[i, 1] + "\t" +
                Math.Round(persons[i, 2], 2) + "\t" +
                bmiStatus[i]
            );
        }

    }
}
