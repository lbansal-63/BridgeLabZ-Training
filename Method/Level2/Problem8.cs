using System;

public class FriendDetails
{
    // Method to find the youngest friend
    public static int FindYoungest(int[] ages)
    {
        int youngest = 0;

        for (int i = 1; i < ages.Length; i++)
        {
            if (ages[i] < ages[youngest])
            {
                youngest = i;
            }
        }

        return youngest;
    }

    // Method to find the tallest friend
    public static int FindTallest(double[] heights)
    {
        int tallest = 0;

        for (int i = 1; i < heights.Length; i++)
        {
            if (heights[i] > heights[tallest])
            {
                tallest = i;
            }
        }

        return tallest;
    }

    public static void Main()
    {
        string[] names = { "Amar", "Akbar", "Anthony" };
        int[] ages = new int[3];
        double[] heights = new double[3];

        // Take input
        for (int i = 0; i < 3; i++)
        {
            Console.Write("Enter age of " + names[i] + ": ");
            ages[i] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter height of " + names[i] + " (in cm): ");
            heights[i] = Convert.ToDouble(Console.ReadLine());
        }

        // Find youngest and tallest
        int youngestIndex = FindYoungest(ages);
        int tallestIndex = FindTallest(heights);

        // Display results
        Console.WriteLine("\nYoungest Friend: " + names[youngestIndex]);
        Console.WriteLine("Age: " + ages[youngestIndex] + " years");

        Console.WriteLine("\nTallest Friend: " + names[tallestIndex]);
        Console.WriteLine("Height: " + heights[tallestIndex] + " cm");
    }
}
