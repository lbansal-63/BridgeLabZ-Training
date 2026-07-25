using System;
public class Number
{
    public static void Main()
    {
        int num;
        Console.Write("Enter the number: ");
        num = Convert.ToInt32(Console.ReadLine());

        if (num <= 0)
        {
            Console.Write("Enter valid Number!!");
            return;
        }

        int sum1 = (num * (num + 1)) / 2;

        int sum2 = 0;
        for(int i=1;i<=num;i++)
        {
            sum2 += i;
        }

        Console.WriteLine("Sum using formula: " + sum1);
        Console.WriteLine("Sum using while loop: " + sum2);

        if (sum1 == sum2)
        {
            Console.WriteLine("Both results are correct and equal.");
        }
        else
        {
            Console.WriteLine("Results are not equal.");
        }
    }
}