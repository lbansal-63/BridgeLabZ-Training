using System;

public static class UnitConvertor
{
    // Convert Fahrenheit to Celsius
    public static double ConvertFahrenheitToCelsius(double fahrenheit)
    {
        double fahrenheit2celsius = (fahrenheit - 32) * 5 / 9;
        return fahrenheit2celsius;
    }

    // Convert Celsius to Fahrenheit
    public static double ConvertCelsiusToFahrenheit(double celsius)
    {
        double celsius2fahrenheit = (celsius * 9 / 5) + 32;
        return celsius2fahrenheit;
    }

    // Convert pounds to kilograms
    public static double ConvertPoundsToKilograms(double pounds)
    {
        double pounds2kilograms = 0.453592;
        return pounds * pounds2kilograms;
    }

    // Convert kilograms to pounds
    public static double ConvertKilogramsToPounds(double kilograms)
    {
        double kilograms2pounds = 2.20462;
        return kilograms * kilograms2pounds;
    }

    // Convert gallons to liters
    public static double ConvertGallonsToLiters(double gallons)
    {
        double gallons2liters = 3.78541;
        return gallons * gallons2liters;
    }

    // Convert liters to gallons
    public static double ConvertLitersToGallons(double liters)
    {
        double liters2gallons = 0.264172;
        return liters * liters2gallons;
    }

    static void Main()
    {
        Console.WriteLine("98.6°F = " + UnitConvertor.ConvertFahrenheitToCelsius(98.6) + "°C");
        Console.WriteLine("37°C = " + UnitConvertor.ConvertCelsiusToFahrenheit(37) + "°F");
        Console.WriteLine("150 pounds = " + UnitConvertor.ConvertPoundsToKilograms(150) + " kg");
        Console.WriteLine("68 kilograms = " + UnitConvertor.ConvertKilogramsToPounds(68) + " pounds");
        Console.WriteLine("5 gallons = " + UnitConvertor.ConvertGallonsToLiters(5) + " liters");
        Console.WriteLine("10 liters = " + UnitConvertor.ConvertLitersToGallons(10) + " gallons");
    }
}
