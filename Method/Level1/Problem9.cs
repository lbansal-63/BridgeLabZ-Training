using System;
public class Program9
{
    public static void RemQuo(int num,int div)
    {
        int quo = num / div; 
        int rem = num % div;

        Console.WriteLine("Quotient: " + quo);
        Console.WriteLine("Remainder: "+rem);
    }

    public static void Main()
    {
        int num;
        Console.Write("Enter the number: ");
        num = Convert.ToInt32(Console.ReadLine());

        int div;
        Console.Write("Enter the divisor: ");
        div = Convert.ToInt32(Console.ReadLine());

        Program9.RemQuo(num,div);

    }
}