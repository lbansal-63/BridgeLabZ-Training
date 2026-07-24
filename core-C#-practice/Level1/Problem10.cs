using System;

class Program
{
    static void Main()
    {
        double height;

        Console.Write("Enter your height in cm: ");
        height = Convert.ToDouble(Console.ReadLine());

        double totalInches = height / 2.54;

        double feet = totalInches / 12;

        double inches = totalInches % 12;

        Console.WriteLine("Your Height in cm is " + height +" while in feet is " + Math.Floor(feet) + " and inches is " + inches);
    }
}
