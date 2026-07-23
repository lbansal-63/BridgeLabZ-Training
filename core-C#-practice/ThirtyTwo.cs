using System; 
public class factorial{
	public static void Main(){

		Console.Write("Enter the number: "); 
		int num; 
		num = Convert.ToInt32(Console.ReadLine()); 

		int fac = 1; 
		int i = 1; 
		while(i<=num){
			fac *= i; 
			i++;  
		}
		
		Console.WriteLine("Factorial: "+fac); 
	}
}