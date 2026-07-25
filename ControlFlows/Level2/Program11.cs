using System;

class FactorsOfNumber
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Factors of " + num + " are:");

        for (int i = 1; i < num; i++)
        {
            if (num % i == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
