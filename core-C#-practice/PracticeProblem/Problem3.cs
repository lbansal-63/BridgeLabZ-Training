//Celsius to Fahrenheit Conversion

using System;
public class Demo3
{
    public static void Main()
    {
        float cel, fah;
        Console.Write("Enter the Celsius Temp: ");
        cel = Convert.ToSingle(Console.ReadLine());


        fah = (cel*9/5) + 32;
        Console.Write("Fahrenheit: " + fah);
    }
}