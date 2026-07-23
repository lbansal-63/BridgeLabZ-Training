using System;
public class PassFail{
	public static void Main(){
		int marks; 
		Console.Write("Enter your marks: "); 
		marks = Convert.ToInt32(Console.ReadLine()); 
		
		string res = (marks>=33) ? "Pass" : "Fail"; 
		Console.WriteLine("You are "+res); 
	}
}