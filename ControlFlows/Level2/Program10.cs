using System;

class PowerOfNumber
{
    static void Main()
    {
        Console.Write("Enter the number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the power: ");
        int power = Convert.ToInt32(Console.ReadLine());

        int res= 1;

        for (int i = 1; i <= power; i++)
        {
            res = res * num;
        }

        Console.WriteLine(num + " raised to the power " + power + " is: " + res);
    }
}
