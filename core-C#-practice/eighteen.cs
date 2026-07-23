using System; 
public class PosNeg{
	public static void Main(){
		int num; 
		
		Console.Write("Enter Number: "); 
		num = Convert.ToInt32(Console.ReadLine()); 
		
		if(num>0){
			Console.WriteLine("Positive!!"); 
		} else{
			Console.WriteLine("Negative!!"); 
		}

	}
}