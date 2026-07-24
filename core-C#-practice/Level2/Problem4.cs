using System;

class Program{
    static void Main(){

        Console.Write("Enter temperature in Celsius: ");
        double cel = Convert.ToDouble(Console.ReadLine());

        double fahr = (cel * 9 / 5) + 32;

        Console.WriteLine("The " + cel + "Celsius is: " + fahr);
    }
}
