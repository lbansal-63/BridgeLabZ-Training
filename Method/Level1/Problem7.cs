using System;
public class Program7
{
    public static int SumOfNum(int n)
    {
        int sum = 0; 
        for(int i = 1; i <= n; i++)
        {
            sum += i; 
        }
        return sum; 
    }

    public static void Main()
    {
        int n;
        Console.Write("Enter the number: ");
        n = Convert.ToInt32(Console.ReadLine());

        int sum = Program7.SumOfNum(n);

        Console.WriteLine("Sum of natural number: "+sum);
        
    }
}