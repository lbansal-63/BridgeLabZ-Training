using System;

class Program
{
    static void Main()
    {
        double Base, height;

        Console.Write("Enter base of triangle in inches: ");
        Base = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter height of triangle in inches: ");
        height = Convert.ToDouble(Console.ReadLine());

        double areaInInc = 0.5 * Base * height;

        double areaInCm = areaInInc * (2.54 * 2.54);

        Console.WriteLine("The area of triangle in square inches is " + areaInInc);
        Console.WriteLine("The area of triangle in square centimeters is " + areaInCm);
    }
}
