using System;

public class CollinearPoints
{
    // Method to check collinear using slope formula
    public static bool CheckUsingSlope(double x1, double y1,
                                       double x2, double y2,
                                       double x3, double y3)
    {
        double slopeAB = (y2 - y1) / (x2 - x1);
        double slopeBC = (y3 - y2) / (x3 - x2);
        double slopeAC = (y3 - y1) / (x3 - x1);

        if (slopeAB == slopeBC && slopeBC == slopeAC)
        {
            return true;
        }

        return false;
    }


    // Method to check collinear using area of triangle formula
    public static bool CheckUsingArea(double x1, double y1,
                                      double x2, double y2,
                                      double x3, double y3)
    {
        double area = 0.5 *
            (x1 * (y2 - y3) +
             x2 * (y3 - y1) +
             x3 * (y1 - y2));

        return area == 0;
    }


    public static void Main()
    {
        Console.WriteLine("Enter coordinates of Point A:");
        Console.Write("x1 = ");
        double x1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("y1 = ");
        double y1 = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine("\nEnter coordinates of Point B:");
        Console.Write("x2 = ");
        double x2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("y2 = ");
        double y2 = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine("\nEnter coordinates of Point C:");
        Console.Write("x3 = ");
        double x3 = Convert.ToDouble(Console.ReadLine());

        Console.Write("y3 = ");
        double y3 = Convert.ToDouble(Console.ReadLine());


        // Check using slope
        if (CheckUsingSlope(x1, y1, x2, y2, x3, y3))
        {
            Console.WriteLine("\nPoints are Collinear using Slope formula");
        }
        else
        {
            Console.WriteLine("\nPoints are not Collinear using Slope formula");
        }


        // Check using area
        if (CheckUsingArea(x1, y1, x2, y2, x3, y3))
        {
            Console.WriteLine("Points are Collinear using Area formula");
        }
        else
        {
            Console.WriteLine("Points are not Collinear using Area formula");
        }
    }
}
