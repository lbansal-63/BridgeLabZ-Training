using System;
public class Number
{
    public static void Main()
    {
        int num1,num2,num3;
        Console.WriteLine("Enter the first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the third number: ");
        num3 = Convert.ToInt32(Console.ReadLine());

        bool IsFirstSmallest = (num1 > num2) && (num1 > num3);
		bool IsSecondSmallest = (num2 > num1) && (num2 > num3);
		bool IsThirdSmallest = (num3 > num1) && (num3 > num2);

        Console.WriteLine("Is the first number the smallest? " + IsSmallest);
		Console.WriteLine("Is the second number the smallest? " + IsSmallest);
		Console.WriteLine("Is the third number the smallest? " + IsSmallest);
	}
}