using System;
public class Program11
{
    public static double WindChill(double temp, double windSpeed)
    {
        double windChill = 35.74 + 0.6215 * temp + (0.4275 * temp - 35.75) * Math.Pow(windSpeed, 0.16);


        return windChill; 
    }

    public static void Main()
    {
        double temp;
        Console.Write("Enter the temperature: ");
        temp = Convert.ToDouble(Console.ReadLine());

        double windSpeed;
        Console.Write("Enter the wind speed: ");
        windSpeed = Convert.ToDouble(Console.ReadLine());

        double WindChill =  Program11.WindChill(temp,windSpeed);
        Console.WriteLine("Wind chill temperature: "+WindChill); 
    }
}