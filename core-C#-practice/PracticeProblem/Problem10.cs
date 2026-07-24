//Convert Kilometers to Miles

using System;
public class Demo4
{
    public static void Main()
    {
        double kilo,mile;
        Console.Write("Enter the distance in kilometer: ");
        kilo = Convert.ToDouble(Console.ReadLine());


        mile = kilo*0.621371;
        Console.Write("Distance in Miles: " + mile);
    }
}