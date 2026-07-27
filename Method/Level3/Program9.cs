using System;

public class EuclideanDistance
{
    // Method to find distance between two points
    public static double FindDistance(double x1, double y1, double x2, double y2)
    {
        double distance = Math.Sqrt(
            Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)
        );

        return distance;
    }


    // Method to find slope and y-intercept
    public static double[] FindLineEquation(double x1, double y1, double x2, double y2)
    {
        double slope = (y2 - y1) / (x2 - x1);

        double yIntercept = y1 - (slope * x1);

        return new double[] { slope, yIntercept };
    }


    public static void Main()
    {
        Console.Write("Enter x1: ");
        double x1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter y1: ");
        double y1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter x2: ");
        double x2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter y2: ");
        double y2 = Convert.ToDouble(Console.ReadLine());


        // Calculate distance
        double distance = FindDistance(x1, y1, x2, y2);

        Console.WriteLine("\nEuclidean Distance = " + distance);


        // Calculate line equation
        double[] equation = FindLineEquation(x1, y1, x2, y2);

        double m = equation[0];
        double b = equation[1];

        Console.WriteLine("Slope (m) = " + m);
        Console.WriteLine("Y-Intercept (b) = " + b);

        Console.WriteLine("Equation of line: y = " + m + "x + " + b);
    }
}
