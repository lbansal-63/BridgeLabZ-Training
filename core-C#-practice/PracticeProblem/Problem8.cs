//Power Calculation

using System;
public class Demo4
{
    public static void Main()
    {
        double b,p;
        Console.Write("Enter the base: ");
        b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the power: ");
        p = Convert.ToDouble(Console.ReadLine());


        double res = Math.Pow(b,p);
        Console.Write("Result: " + res);
    }
}