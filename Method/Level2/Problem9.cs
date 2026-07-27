using System;

public class NumberCheck
{
    public static bool IsPositive(int number)
    {
        return number >= 0;
    }

    public static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    public static int Compare(int number1, int number2)
    {
        if (number1 > number2)
        {
            return 1;
        }
        else if (number1 == number2)
        {
            return 0;
        }
        else
        {
            return -1;
        }
    }

    public static void Main()
    {
        int[] numbers = new int[5];
        
        Console.WriteLine("Enter 5 numbers:");

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            if (IsPositive(numbers[i]))
            {
                Console.Write(numbers[i] + " is Positive");

                if (IsEven(numbers[i]))
                {
                    Console.WriteLine(" and Even");
                }
                else
                {
                    Console.WriteLine(" and Odd");
                }
            }
            else
            {
                Console.WriteLine(numbers[i] + " is Negative");
            }
        }

        int result = Compare(numbers[0], numbers[numbers.Length - 1]);

        if (result == 1)
        {
            Console.WriteLine("First element is greater than last element.");
        }
        else if (result == 0)
        {
            Console.WriteLine("First element and last element are equal.");
        }
        else
        {
            Console.WriteLine("First element is less than last element.");
        }
    }
}
