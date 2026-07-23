using System; 
public class Ternary{
	public static void Main(){
		int age; 	
		Console.Write("Enter your age: "); 
		age = Convert.ToInt32(Console.ReadLine());

		string res = (age>=18) ? "Adult" : "Minor"; 
		Console.WriteLine("You are: "+res); 
	}
}