using System;

class CountDigits
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int count = 0;

        while (number != 0)
        {
            number = number / 10;
            count++;
        }

        Console.WriteLine("Number of digits: " + count);
    }
}
