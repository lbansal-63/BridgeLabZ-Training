//Calculate Average of Three Numbers

using System;
public class Demo2
{
    public static void Main()
    {
        int num1, num2, num3;
        Console.Write("Enter the first Number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second Number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the third Number: ");
        num3 = Convert.ToInt32(Console.ReadLine());

        float res = (num1+num2+num3)/3;
        Console.Write("Avg of three Number is: " + res);
    }
}