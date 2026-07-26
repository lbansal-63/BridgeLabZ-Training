using System;

public class Array
{
    public static void Main()
    {
        int num;

        Console.Write("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());

        if (num < 0)
        {
            Console.WriteLine("ERROR!! Enter a positive integer");
            return;
        }

        string[] result = new string[number + 1];

        for (int i = 0; i <= num; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                result[i] = "FizzBuzz";
            }
            else if (i % 3 == 0)
            {
                result[i] = "Fizz";
            }
            else if (i % 5 == 0)
            {
                result[i] = "Buzz";
            }
            else
            {
                result[i] = i.ToString();
            }
        }

        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine("Position " + i + " = " + result[i]);
        }
    }
}
