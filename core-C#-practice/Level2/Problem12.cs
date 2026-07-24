using System;

class Program
{
    static void Main(){

        Console.Write("Enter Weight in Pounds: ");
        double pounds = Convert.ToDouble(Console.ReadLine());

        double kilo = pounds / 2.2;

        Console.WriteLine("The weight of the person in pounds is " + pounds + " and in kg is " + kilo);
    }
}
