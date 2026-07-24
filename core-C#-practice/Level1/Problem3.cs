
using System;
public class Demo4
{
    public static void Main()
    {
        double kilo, mile;
        Console.Write("Enter the distance in Miles: ");
        mile = Convert.ToDouble(Console.ReadLine());


        mile = kilo * 1.6;
        Console.Write("The distance "+kilo+" km in miles is " + mile);
    }
}