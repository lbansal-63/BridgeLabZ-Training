using System; 
public class WhileLoop{
	public static void Main(){
		Console.Write("Enter the number: "); 
		int num; 
		num = Convert.ToInt32(Console.ReadLine()); 
		
		// initialization 
		int i = 1; 

		while(i<=num){
			Console.WriteLine(i); 
			i++; 
		}

	}
}