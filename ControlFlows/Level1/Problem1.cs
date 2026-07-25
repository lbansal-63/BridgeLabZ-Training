using System;
public class Number
{
    public static void Main()
    {
        int num;
        Console.WriteLine("Enter the number: "); 
        num = Convert.ToInt32(Console.ReadLine());

        if (num % 5 == 0)
        {
            Console.WriteLine("Number is divisible by 5."); 
        } else
        {
            Console.WriteLine("Number is not divisible by 5."); 
        }
    }
}