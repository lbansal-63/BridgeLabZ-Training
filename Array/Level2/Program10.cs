using System;

public class Array
{
    public static void Main()
    {
        int num;

        Console.Write("Enter number: ");
        num = Convert.ToInt32(Console.ReadLine());


        int[] digits = new int[10];
        int index = 0;


        while (num != 0)
        {
            digits[index] = num % 10;
            num = num / 10;
            index++;
        }


        int[] frequency = new int[10];


        for (int i = 0; i < index; i++)
        {
            frequency[digits[i]]++;
        }


        Console.WriteLine("Digit Frequency:");

        for (int i = 0; i < 10; i++)
        {
            if (frequency[i] > 0)
            {
                Console.WriteLine(i + " appears " + frequency[i] + " times");
            }
        }
    }
}
