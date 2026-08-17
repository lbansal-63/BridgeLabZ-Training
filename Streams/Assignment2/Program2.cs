using System;
using System.Text;

class Program
{
	static string RemoveDuplicates(string input)
	{
		StringBuilder result = new StringBuilder();

		for (int i = 0; i < input.Length; i++)
		{
			bool duplicate = false;

			for (int j = 0; j < result.Length; j++)
			{
				if (input[i] == result[j])
				{
					duplicate = true;
					break;
				}
			}

			if (!duplicate)
			{
				result.Append(input[i]);
			}
		}

		return result.ToString();
	}

	static void Main()
	{
		Console.Write("Enter a string: ");
		string input = Console.ReadLine();

		Console.WriteLine("Without duplicates: " + RemoveDuplicates(input));
	}
}