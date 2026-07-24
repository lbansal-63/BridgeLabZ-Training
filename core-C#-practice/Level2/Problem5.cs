using System;

class Program
{
    static void Main(){

        Console.Write("Enter temperature in Fahrenheit: ");
        double fahr = Convert.ToDouble(Console.ReadLine());

        double cel = (fahr - 32) * 5 / 9;

        Console.WriteLine("The " + fahr + " Fahrenheit is " + cel + " Celsius");
    }
}
