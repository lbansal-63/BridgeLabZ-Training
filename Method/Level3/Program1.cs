using System;

public class FootballTeam
{
    // Method to find sum of all heights
    public static int FindSum(int[] heights)
    {
        int sum = 0;

        for (int i = 0; i < heights.Length; i++)
        {
            sum += heights[i];
        }

        return sum;
    }

    // Method to find mean height
    public static double FindMean(int[] heights)
    {
        int sum = FindSum(heights);

        return (double)sum / heights.Length;
    }

    // Method to find shortest height
    public static int FindShortest(int[] heights)
    {
        int shortest = heights[0];

        for (int i = 1; i < heights.Length; i++)
        {
            if (heights[i] < shortest)
            {
                shortest = heights[i];
            }
        }

        return shortest;
    }

    // Method to find tallest height
    public static int FindTallest(int[] heights)
    {
        int tallest = heights[0];

        for (int i = 1; i < heights.Length; i++)
        {
            if (heights[i] > tallest)
            {
                tallest = heights[i];
            }
        }

        return tallest;
    }

    public static void Main()
    {
        int[] heights = new int[11];
        Random random = new Random();

        // Generate random heights between 150 and 250 cm
        for (int i = 0; i < heights.Length; i++)
        {
            heights[i] = random.Next(150, 251);
        }

        Console.WriteLine("Heights of 11 Football Players:");

        for (int i = 0; i < heights.Length; i++)
        {
            Console.WriteLine("Player " + (i + 1) + ": " + heights[i] + " cm");
        }

        int sum = FindSum(heights);
        double mean = FindMean(heights);
        int shortest = FindShortest(heights);
        int tallest = FindTallest(heights);

        Console.WriteLine("\nTotal Height = " + sum + " cm");
        Console.WriteLine("Mean Height = " + mean + " cm");
        Console.WriteLine("Shortest Height = " + shortest + " cm");
        Console.WriteLine("Tallest Height = " + tallest + " cm");
    }
}
