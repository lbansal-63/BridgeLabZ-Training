using System;

public class Array
{
    public static void Main()
    {
        int number;

        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        int temp = number;
        int count = 0;

        // Count digits
        while (temp != 0)
        {
            count++;
            temp = temp / 10;
        }

        int[] digits = new int[count];

        // Store digits in array
        int index = 0;

        while (number != 0)
        {
            digits[index] = number % 10;
            number = number / 10;
            index++;
        }


        // Create reverse array
        int[] reverse = new int[count];

        for (int i = 0; i < count; i++)
        {
            reverse[i] = digits[i];
        }


        // Display reverse number
        Console.Write("Reverse number: ");

        for (int i = 0; i < reverse.Length; i++)
        {
            Console.Write(reverse[i]);
        }
    }
}
