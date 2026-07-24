//Add Two Numbers

using System;
public class Demo2
{
    public static void Main()
    {
        int num1,num2,sum=0;
        Console.Write("Enter the first Number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second Number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        sum = num1 + num2;
        Console.Write("Sum of Two Number is: "+sum);
    }
}