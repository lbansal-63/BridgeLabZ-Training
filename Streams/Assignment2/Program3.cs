using System;
using System.Text;

class Program
{
	static string ConcatenateStrings(string[] words)
	{
		StringBuilder sb = new StringBuilder();

		foreach (string word in words)
		{
			sb.Append(word);
		}

		return sb.ToString();
	}

	static void Main()
	{
		string[] words = { "Hello", " ", "World", "!", " Welcome" };

		string result = ConcatenateStrings(words);

		Console.WriteLine(result);
	}
}