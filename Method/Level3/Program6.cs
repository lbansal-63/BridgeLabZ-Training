using System;

public class NumberChecker
{
    // Method to find factors and return array
    public static int[] FindFactors(int number)
    {
        int count = 0;

        // Count factors
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                count++;
            }
        }

        int[] factors = new int[count];
        int index = 0;

        // Store factors
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                factors[index] = i;
                index++;
            }
        }

        return factors;
    }


    // Method to find greatest factor
    public static int FindGreatestFactor(int[] factors)
    {
        int greatest = factors[0];

        for (int i = 0; i < factors.Length; i++)
        {
            if (factors[i] > greatest)
            {
                greatest = factors[i];
            }
        }

        return greatest;
    }


    // Method to find sum of factors
    public static int FindSumOfFactors(int[] factors)
    {
        int sum = 0;

        for (int i = 0; i < factors.Length; i++)
        {
            sum += factors[i];
        }

        return sum;
    }


    // Method to find product of factors
    public static long FindProductOfFactors(int[] factors)
    {
        long product = 1;

        for (int i = 0; i < factors.Length; i++)
        {
            product *= factors[i];
        }

        return product;
    }


    // Method to find product of cubes of factors
    public static double FindProductOfCubeFactors(int[] factors)
    {
        double product = 1;

        for (int i = 0; i < factors.Length; i++)
        {
            product *= Math.Pow(factors[i], 3);
        }

        return product;
    }


    // Method to check Perfect Number
    public static bool IsPerfectNumber(int number, int[] factors)
    {
        int sum = 0;

        for (int i = 0; i < factors.Length - 1; i++)
        {
            sum += factors[i];
        }

        return sum == number;
    }


    // Method to check Abundant Number
    public static bool IsAbundantNumber(int number, int[] factors)
    {
        int sum = 0;

        for (int i = 0; i < factors.Length - 1; i++)
        {
            sum += factors[i];
        }

        return sum > number;
    }


    // Method to check Deficient Number
    public static bool IsDeficientNumber(int number, int[] factors)
    {
        int sum = 0;

        for (int i = 0; i < factors.Length - 1; i++)
        {
            sum += factors[i];
        }

        return sum < number;
    }


    // Method to find factorial
    public static int Factorial(int number)
    {
        int fact = 1;

        for (int i = 1; i <= number; i++)
        {
            fact *= i;
        }

        return fact;
    }


    // Method to check Strong Number
    public static bool IsStrongNumber(int number)
    {
        int temp = number;
        int sum = 0;

        while (temp > 0)
        {
            int digit = temp % 10;
            sum += Factorial(digit);
            temp /= 10;
        }

        return sum == number;
    }


    public static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int[] factors = FindFactors(number);

        Console.Write("Factors: ");
        for (int i = 0; i < factors.Length; i++)
        {
            Console.Write(factors[i] + " ");
        }

        Console.WriteLine();

        Console.WriteLine("Greatest Factor: " + FindGreatestFactor(factors));
        Console.WriteLine("Sum of Factors: " + FindSumOfFactors(factors));
        Console.WriteLine("Product of Factors: " + FindProductOfFactors(factors));
        Console.WriteLine("Product of Cube of Factors: " + FindProductOfCubeFactors(factors));


        if (IsPerfectNumber(number, factors))
            Console.WriteLine(number + " is a Perfect Number");
        else
            Console.WriteLine(number + " is not a Perfect Number");


        if (IsAbundantNumber(number, factors))
            Console.WriteLine(number + " is an Abundant Number");
        else
            Console.WriteLine(number + " is not an Abundant Number");


        if (IsDeficientNumber(number, factors))
            Console.WriteLine(number + " is a Deficient Number");
        else
            Console.WriteLine(number + " is not a Deficient Number");


        if (IsStrongNumber(number))
            Console.WriteLine(number + " is a Strong Number");
        else
            Console.WriteLine(number + " is not a Strong Number");
    }
}
