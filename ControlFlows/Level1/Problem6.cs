using System;
public class Number
{
    public static void Main()
    {
        int num;
        Console.WriteLine("Enter the number: ");
        num = Convert.ToInt32(Console.ReadLine());

        if (num > 0)
        {
            Console.WriteLine("Positive");
        }
        else if(num < 0)
        {
            Console.WriteLine("Negative");
        }
        else
        {
            Console.WriteLine("Zero");
        }
    }
}