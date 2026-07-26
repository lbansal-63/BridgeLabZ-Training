using System;
public class Array
{
    public static void Main()
    {
        double[] height = new double[11];

        for (int i = 0; i < height.Length; i++)
        {
            Console.Write("Enter the height of player " + (i + 1) + " : ");
            height[i] = Convert.ToDouble(Console.ReadLine());
        }

        double sum = 0;
        for (int i = 0; i < height.Length; i++)
        {
            sum += height[i];
        }

        double mean = sum / height.Length;
        Console.Write("Mean height of the football team: " + mean);
    }
}