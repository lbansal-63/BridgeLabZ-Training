using System;

public class NumberChecker
{
	// Method to find count of digits
	public static int CountDigits(int number)
	{
		int count = 0;

		while (number > 0)
		{
			count++;
			number = number / 10;
		}

		return count;
	}

	// Method to store digits in array
	public static int[] StoreDigits(int number)
	{
		int count = CountDigits(number);
		int[] digits = new int[count];

		for (int i = count - 1; i >= 0; i--)
		{
			digits[i] = number % 10;
			number = number / 10;
		}

		return digits;
	}

	// Method to check Duck number
	public static bool IsDuckNumber(int[] digits)
	{
		for (int i = 0; i < digits.Length; i++)
		{
			if (digits[i] == 0)
			{
				return true;
			}
		}

		return false;
	}

	// Method to check Armstrong number
	public static bool IsArmstrongNumber(int number, int[] digits)
	{
		int sum = 0;
		int power = digits.Length;

		for (int i = 0; i < digits.Length; i++)
		{
			sum += (int)Math.Pow(digits[i], power);
		}

		return sum == number;
	}

	// Method to find largest and second largest digits
	public static int[] FindLargestAndSecondLargest(int[] digits)
	{
		int largest = Int32.MinValue;
		int secondLargest = Int32.MinValue;

		for (int i = 0; i < digits.Length; i++)
		{
			if (digits[i] > largest)
			{
				secondLargest = largest;
				largest = digits[i];
			}
			else if (digits[i] > secondLargest && digits[i] != largest)
			{
				secondLargest = digits[i];
			}
		}

		return new int[] { largest, secondLargest };
	}

	// Method to find smallest and second smallest digits
	public static int[] FindSmallestAndSecondSmallest(int[] digits)
	{
		int smallest = Int32.MaxValue;
		int secondSmallest = Int32.MaxValue;

		for (int i = 0; i < digits.Length; i++)
		{
			if (digits[i] < smallest)
			{
				secondSmallest = smallest;
				smallest = digits[i];
			}
			else if (digits[i] < secondSmallest && digits[i] != smallest)
			{
				secondSmallest = digits[i];
			}
		}

		return new int[] { smallest, secondSmallest };
	}


	public static void Main()
	{
		Console.Write("Enter a number: ");
		int number = Convert.ToInt32(Console.ReadLine());

		int count = CountDigits(number);
		Console.WriteLine("Number of digits: " + count);

		int[] digits = StoreDigits(number);

		Console.Write("Digits array: ");
		for (int i = 0; i < digits.Length; i++)
		{
			Console.Write(digits[i] + " ");
		}

		Console.WriteLine();

		// Duck number check
		if (IsDuckNumber(digits))
			Console.WriteLine("It is a Duck Number");
		else
			Console.WriteLine("It is not a Duck Number");


		// Armstrong number check
		if (IsArmstrongNumber(number, digits))
			Console.WriteLine("It is an Armstrong Number");
		else
			Console.WriteLine("It is not an Armstrong Number");


		// Largest values
		int[] largest = FindLargestAndSecondLargest(digits);
		Console.WriteLine("Largest Digit: " + largest[0]);
		Console.WriteLine("Second Largest Digit: " + largest[1]);


		// Smallest values
		int[] smallest = FindSmallestAndSecondSmallest(digits);
		Console.WriteLine("Smallest Digit: " + smallest[0]);
		Console.WriteLine("Second Smallest Digit: " + smallest[1]);
	}
}
