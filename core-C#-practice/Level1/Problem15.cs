using System;

class Program
{
    static void Main()
    {
        int unitPrice, quant;

        Console.Write("Enter the unit price of an item: ");
        unitPrice = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the quantity: ");
        quant = Convert.ToInt32(Console.ReadLine());

        int totPrice = unitPrice * quant;
        Console.WriteLine(" The total purchase price is INR" + totPrice + "if the quantity" + quant + " and unit price is INR " + unitPrice);
    }
}
