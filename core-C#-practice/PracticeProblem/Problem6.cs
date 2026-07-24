//Calculate Simple Interest

using System;
public class Demo4
{
    public static void Main()
    {
        float p, r, t,si;
        Console.Write("Enter the Principal Amount: ");
        p = Convert.ToSingle(Console.ReadLine());

        Console.Write("Enter the Rate of Interest: ");
        r = Convert.ToSingle(Console.ReadLine());

        Console.Write("Enter the time period: ");
        t = Convert.ToSingle(Console.ReadLine());

        si = p*r*t;
        Console.Write("Simple Interest: " + si);
    }
}