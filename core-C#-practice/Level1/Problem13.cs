using System;

class Program
{
    static void Main()
    {

        double per;

        Console.Write("Enter perimeter of square: ");
        per = Convert.ToDouble(Console.ReadLine());

        double side = per / 4;

        Console.WriteLine("The length of the side is " + side + " whose perimeter is " + per);
    }
}
