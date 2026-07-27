using System;

public class NumberChecker
{
    // Method to check Prime Number
    public static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }


    // Method to check Neon Number
    public static bool IsNeonNumber(int number)
    {
        int square = number * number;
        int sum = 0;

        while (square > 0)
        {
            sum += square % 10;
            square = square / 10;
        }

        return sum == number;
    }


    // Method to check Spy Number
    public static bool IsSpyNumber(int number)
    {
        int sum = 0;
        int product = 1;

        while (number > 0)
        {
            int digit = number % 10;

            sum += digit;
            product *= digit;

            number = number / 10;
        }

        return sum == product;
    }


    // Method to check Automorphic Number
    public static bool IsAutomorphicNumber(int number)
    {
        int square = number * number;

        return square.ToString().EndsWith(number.ToString());
    }


    // Method to check Buzz Number
    public static bool IsBuzzNumber(int number)
    {
        return number % 7 == 0 || number % 10 == 7;
    }


    public static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());


        // Prime Check
        if (IsPrime(number))
            Console.WriteLine(number + " is a Prime Number");
        else
            Console.WriteLine(number + " is not a Prime Number");


        // Neon Check
        if (IsNeonNumber(number))
            Console.WriteLine(number + " is a Neon Number");
        else
            Console.WriteLine(number + " is not a Neon Number");


        // Spy Check
        if (IsSpyNumber(number))
            Console.WriteLine(number + " is a Spy Number");
        else
            Console.WriteLine(number + " is not a Spy Number");


        // Automorphic Check
        if (IsAutomorphicNumber(number))
            Console.WriteLine(number + " is an Automorphic Number");
        else
            Console.WriteLine(number + " is not an Automorphic Number");


        // Buzz Check
        if (IsBuzzNumber(number))
            Console.WriteLine(number + " is a Buzz Number");
        else
            Console.WriteLine(number + " is not a Buzz Number");
    }
}
