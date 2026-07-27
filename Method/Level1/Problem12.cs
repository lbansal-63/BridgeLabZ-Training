using System;
public class Program12
{
    public static void Trigo(double angle)
    {
        double rad = angle * Math.PI / 180;
        double sin = Math.Sin(rad);
        double cos = Math.Cos(rad);
        double tan = Math.Tan(rad);

        Console.WriteLine("Sin: " + sin);
        Console.WriteLine("Cos: " + cos);
        Console.WriteLine("Tan: " + tan);
    }

    public static void Main()
    {
        double angle;
        Console.Write("Enter the angle(in degree): ");
        angle = Convert.ToDouble(Console.ReadLine());

        Program12.Trigo(angle);
    }
}