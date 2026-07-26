using System;

public class Array
{
	public static void Main()
	{
		string[] friends = { "Amar", "Akbar", "Anthony" };

		int[] age = new int[3];
		double[] height = new double[3];

		// Taking input
		for (int i = 0; i < friends.Length; i++)
		{
			Console.Write("Enter age of " + friends[i] + ": ");
			age[i] = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter height of " + friends[i] + ": ");
			height[i] = Convert.ToDouble(Console.ReadLine());
		}

		int youngestIndex = 0;
		int tallestIndex = 0;

		// Finding youngest and tallest
		for (int i = 1; i < friends.Length; i++)
		{
			if (age[i] < age[youngestIndex])
			{
				youngestIndex = i;
			}

			if (height[i] > height[tallestIndex])
			{
				tallestIndex = i;
			}
		}

		// Display result
		Console.WriteLine("\nYoungest friend is: " + friends[youngestIndex]);
		Console.WriteLine("Age: " + age[youngestIndex]);

		Console.WriteLine("\nTallest friend is: " + friends[tallestIndex]);
		Console.WriteLine("Height: " + height[tallestIndex]);
	}
}
