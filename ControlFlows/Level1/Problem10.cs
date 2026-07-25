using System;
public class SumOfNum {
	public static void Main() {
		double total = 0;

		double n = -1;


		while (n != 0) {
			Console.Write("Enter the number: ");
			n = Convert.ToInt32(Console.ReadLine());
			if (n != 0) {
				total += n;
			}
		}

		Console.WriteLine("Total: " + total); 
	}
}