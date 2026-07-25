using System;

class ArmstrongNumber
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int sum = 0;
        int originalNumber = number;

        while (originalNumber != 0)
        {
            int digit = originalNumber % 10;
            sum = sum + (digit * digit * digit);
            originalNumber = originalNumber / 10;
        }

        if (number == sum)
        {
            Console.WriteLine(number + " is an Armstrong Number");
        }
        else
        {
            Console.WriteLine(number + " is not an Armstrong Number");
        }
    }
}
