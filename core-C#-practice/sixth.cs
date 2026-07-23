using System;  
public class NumInput{
	public static void Main(){
		int num1, num2, res; 

		Console.Write("Enter the first Number :"); 
		num1 = Convert.ToInt32(Console.ReadLine()); 

		Console.Write("Enter the second Number :"); 
		num2 = Convert.ToInt32(Console.ReadLine()); 
		
		res = num1 + num2; 
		Console.WriteLine("Sum: "+res); 
	}
}