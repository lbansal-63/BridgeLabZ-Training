using System;

public class Array
{
    public static void Main()
    {
        int number;

        Console.Write("Enter number of persons: ");
        number = Convert.ToInt32(Console.ReadLine());

        double[,] personData = new double[number, 3];
        string[] weightStatus = new string[number];


        for (int i = 0; i < number; i++)
        {
            Console.Write("Enter weight (kg): ");
            personData[i, 0] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter height (m): ");
            personData[i, 1] = Convert.ToDouble(Console.ReadLine());


            if (personData[i, 0] < 0 || personData[i, 1] < 0)
            {
                Console.WriteLine("Enter positive values");
                i--;
            }
        }


        for (int i = 0; i < number; i++)
        {
            personData[i, 2] =
                personData[i, 0] / (personData[i, 1] * personData[i, 1]);


            if (personData[i, 2] <= 18.4)
            {
                weightStatus[i] = "Underweight";
            }
            else if (personData[i, 2] <= 24.9)
            {
                weightStatus[i] = "Normal";
            }
            else if (personData[i, 2] <= 39.9)
            {
                weightStatus[i] = "Overweight";
            }
            else
            {
                weightStatus[i] = "Obese";
            }
        }


        for (int i = 0; i < number; i++)
        {
            Console.WriteLine("\nPerson " + (i + 1));
            Console.WriteLine("Weight: " + personData[i, 0]);
            Console.WriteLine("Height: " + personData[i, 1]);
            Console.WriteLine("BMI: " + personData[i, 2]);
            Console.WriteLine("Status: " + weightStatus[i]);
        }
    }
}
