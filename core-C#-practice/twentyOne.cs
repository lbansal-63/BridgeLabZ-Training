using System; 
public class PosNegZero{
	public static void Main(){
		int num; 
		Console.Write("Enter the number: "); 
		num = Convert.ToInt32(Console.ReadLine());
		
		if(num==0){
			Console.WriteLine("Zero Number");
		}else if(num>0){
			Console.WriteLine("Positive Number");
		}else{
			Console.WriteLine("Negative Number"); 
		}

	}
}