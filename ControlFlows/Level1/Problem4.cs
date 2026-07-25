using System;
public class Number
{
	public static void Main()
	{
		int num;
		Console.WriteLine("Enter the number: ");
		num = Convert.ToInt32(Console.ReadLine());

		if (num > 0) {
			sum = (num * (num + 1)) / 2;
			Console.WriteLine("The sum of " + num + " natural number is "+sum);
		}
		else
		{
			Console.WriteLine("The number "+num+" is not natural number");
		}
	}
}