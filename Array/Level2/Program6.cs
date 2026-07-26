using System;

public class Array
{
    public static void Main()
    {
        int number;

        Console.Write("Enter number of persons: ");
        number = Convert.ToInt32(Console.ReadLine());

        double[] weight = new double[number];
        double[] height = new double[number];
        double[] bmi = new double[number];
        string[] status = new string[number];


        for (int i = 0; i < number; i++)
        {
            Console.Write("Enter weight (kg): ");
            weight[i] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter height (m): ");
            height[i] = Convert.ToDouble(Console.ReadLine());

            if (weight[i] < 0 || height[i] < 0)
            {
                Console.WriteLine("Enter positive values");
                i--;
            }
        }


        for (int i = 0; i < number; i++)
        {
            bmi[i] = weight[i] / (height[i] * height[i]);

            if (bmi[i] <= 18.4)
            {
                status[i] = "Underweight";
            }
            else if (bmi[i] <= 24.9)
            {
                status[i] = "Normal";
            }
            else if (bmi[i] <= 39.9)
            {
                status[i] = "Overweight";
            }
            else
            {
                status[i] = "Obese";
            }
        }


        for (int i = 0; i < number; i++)
        {
            Console.WriteLine("\nPerson " + (i + 1));
            Console.WriteLine("Height: " + height[i]);
            Console.WriteLine("Weight: " + weight[i]);
            Console.WriteLine("BMI: " + bmi[i]);
            Console.WriteLine("Status: " + status[i]);
        }
    }
}
