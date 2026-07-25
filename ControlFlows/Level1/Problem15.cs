using System;
public class factorial
{
    public static void Main()
    {
        int num;
        Console.Write("Enter the number: ");
        num = Convert.ToInt32(Console.ReadLine());

        if (num < 0)
        {
            Console.Write("Enter the valid number");
            return;
        }

        int fac = 1;
        for(int i=1;i<=num;i++)
        {
            fac *= i; 
        }

        Console.WriteLine("Factorial: " + fac);
    }
}