using System; 
public class WhileLoop{
	public static void Main(){
		Console.Write("Enter the number: "); 
		int num; 
		num = Convert.ToInt32(Console.ReadLine()); 
		
		int i = 1; 
		int sum = 0; 
		while(i<=num){
			sum += i; 
			i++; 
		}
		Console.WriteLine("Sum of 1 to "+num+" is: "+sum); 
	}
}