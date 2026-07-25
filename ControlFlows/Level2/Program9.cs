using System;

class GreatestFactor
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int gf = 1;

        for (int i = num - 1; i >= 1; i--)
        {
            if (num % i == 0)
            {
                gf = i;
                break;
            }
        }

        Console.WriteLine("Greatest Factor of " + num + " is: " + gf);
    }
}
