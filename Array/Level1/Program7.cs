using System;
public class Array
{
	public static void Main()
	{
		int num;
		Console.Write("Enter the number: ");
		num = Convert.ToInt32(Console.ReadLine());

		if (num <= 0) {
			Console.Write("ERROR!!");
			return; 
		}

		int[] even = new int[num/2+1];
		int[] odd = new int[num / 2 + 1];

		int oddIdx = 0;
		int evenIdx = 0;
		for (int i = 1; i <= num; i++)
		{
			if (i % 2 == 0)
			{
				even[evenIdx++] = i;
			}
			else
			{
				odd[oddIdx++] = i;
			}
		}

		Console.Write("Even Array: ");
		for (int i = 0; i < evenIdx; i++)
		{
			Console.Write(even[i]+" ");
		}

		Console.Write("Odd Array: ");
		for (int i = 0; i < oddIdx; i++)
		{
			Console.Write(odd[i]+" ");
		}

	}
}